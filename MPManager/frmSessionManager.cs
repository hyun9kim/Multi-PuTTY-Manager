using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SessionManagement.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace SessionManagement
{
	// Token: 0x02000010 RID: 16
	public partial class frmSessionManager : DockContent
	{
		// Token: 0x060000ED RID: 237 RVA: 0x0000E2E6 File Offset: 0x0000C4E6
		public frmSessionManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000E300 File Offset: 0x0000C500
		public string createUniqueNodeName(TreeNode treeNode, string inputName, string type)
		{
			string text = inputName;
			int i = 0;
			int num = 2;
			string result;
			try
			{
				if (type == "folder")
				{
					while (i < treeNode.Nodes.Count)
					{
						if (treeNode.Nodes[i].Text == text && int.Parse(treeNode.Nodes[i].Name) == 0)
						{
							text = inputName + "(" + num.ToString() + ")";
							num++;
							i = -1;
						}
						i++;
					}
				}
				else
				{
					while (i < treeNode.Nodes.Count)
					{
						if (treeNode.Nodes[i].Text == text && int.Parse(treeNode.Nodes[i].Name) > 0)
						{
							text = inputName + "(" + num.ToString() + ")";
							num++;
							i = -1;
						}
						i++;
					}
				}
				result = text;
			}
			catch (Exception ex)
			{
				result = text;
			}
			return result;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000E450 File Offset: 0x0000C650
		public void createNewFolder(TreeNode treeNode)
		{
			TreeNode treeNode2 = new TreeNode();
			treeNode2.Name = "0";
			treeNode2.Text = this.createUniqueNodeName(treeNode, "New Folder", "folder");
			treeNode2.ContextMenuStrip = this.contextForFolder;
			treeNode2.ImageIndex = 1;
			treeNode2.SelectedImageIndex = 1;
			treeNode2.EnsureVisible();
			treeNode.Nodes.Add(treeNode2);
			this.treeSessions.SelectedNode = treeNode2;
			treeNode2.BeginEdit();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000E4CD File Offset: 0x0000C6CD
		private void contextFolderForDatabase_Click(object sender, EventArgs e)
		{
			this.createNewFolder(this.treeSessions.SelectedNode);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000E4E2 File Offset: 0x0000C6E2
		private void treeSessions_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			this.treeSessions.SelectedNode = e.Node;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000E4F7 File Offset: 0x0000C6F7
		private void contextFolderForFolder_Click(object sender, EventArgs e)
		{
			this.createNewFolder(this.treeSessions.SelectedNode);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000E50C File Offset: 0x0000C70C
		private void contextSessionForFolder_Click(object sender, EventArgs e)
		{
			new frmSession
			{
				createOrUpdateSession = new frmSession.CreateOrUpdateSession(this.createOrUpdateSession)
			}.ShowDialog();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000E53C File Offset: 0x0000C73C
		private void contextSessionForDatabase_Click(object sender, EventArgs e)
		{
			new frmSession
			{
				createOrUpdateSession = new frmSession.CreateOrUpdateSession(this.createOrUpdateSession)
			}.ShowDialog();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000E56C File Offset: 0x0000C76C
		public void createOrUpdateSession(Session sess)
		{
			try
			{
				TreeNode selectedNode = this.treeSessions.SelectedNode;
				if (int.Parse(selectedNode.Name) <= 0)
				{
					if (Global.arrAvailableSessions == null)
					{
						Global.arrAvailableSessions = new ArrayList();
					}
					Global.arrAvailableSessions.Add(sess);
					TreeNode treeNode = new TreeNode();
					treeNode.Name = sess.sessionID.ToString();
					treeNode.Text = sess.sessionName;
					treeNode.ContextMenuStrip = this.contextForSession;
					treeNode.ImageIndex = 2;
					treeNode.SelectedImageIndex = 2;
					treeNode.EnsureVisible();
					treeNode.BeginEdit();
					this.setToolTipsForSessionNode(treeNode, sess);
					this.treeSessions.SelectedNode.Nodes.Add(treeNode);
					this.alertWhenDuplicateNodeName(treeNode);
					this.treeSessions.SelectedNode = treeNode;
				}
				else
				{
					this.modifyExistingSession(selectedNode, sess);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000E670 File Offset: 0x0000C870
		public void modifyExistingSession(TreeNode selectedNode, Session sess)
		{
			if (selectedNode.Name == sess.sessionID.ToString())
			{
				selectedNode.Text = sess.sessionName;
				this.setToolTipsForSessionNode(selectedNode, sess);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		private void treeSessions_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (int.Parse(e.Node.Name) > 0)
			{
				Session session = this.findSessionFromAvailableSessions(int.Parse(e.Node.Name));
				if (session != null)
				{
					this.openSession(session);
				}
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000E70C File Offset: 0x0000C90C
		private void contextConnect_Click(object sender, EventArgs e)
		{
			Session session = this.findSessionFromAvailableSessions(int.Parse(this.treeSessions.SelectedNode.Name));
			if (session != null)
			{
				this.openSession(session);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000E74C File Offset: 0x0000C94C
		public Session findSessionFromAvailableSessions(int ID)
		{
			Session result;
			if (Global.arrAvailableSessions == null)
			{
				result = null;
			}
			else if (((Session)Global.arrAvailableSessions[ID - 1]).sessionID == ID)
			{
				result = (Session)Global.arrAvailableSessions[ID - 1];
			}
			else
			{
				for (int i = 0; i < Global.arrAvailableSessions.Count; i++)
				{
					if (((Session)Global.arrAvailableSessions[i]).sessionID == ID)
					{
						return (Session)Global.arrAvailableSessions[i];
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000E7FC File Offset: 0x0000C9FC
		public void openDatabase(string fileType)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (fileType == "dat")
				{
					openFileDialog.Filter = "Database Files (*.dat)|*.dat";
					openFileDialog.Title = "Open database";
				}
				else if (fileType == "xml")
				{
					openFileDialog.Filter = "XML Files (*.xml)|*.xml";
					openFileDialog.Title = "Select XML file to import";
				}
				openFileDialog.FilterIndex = 0;
				openFileDialog.RestoreDirectory = true;
				openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\Databases";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					this.loadDatabaseFromXMLFile(fileName, this.treeSessions);
					if (fileType == "xml")
					{
						MessageBox.Show("Database is imported successfully!", "Import database", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000E8FC File Offset: 0x0000CAFC
		private void contextOpenDatabase_Click(object sender, EventArgs e)
		{
			this.openDatabase("dat");
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000E90C File Offset: 0x0000CB0C
		public void createDatabaseIDAndLocation(TreeNode treeNode, string location)
		{
			if (Global.arrDatabaseLocation == null)
			{
				Global.arrDatabaseLocation = new ArrayList();
			}
			if (Path.GetExtension(location) != ".dat")
			{
				Global.arrDatabaseLocation.Add("");
			}
			else
			{
				Global.arrDatabaseLocation.Add(location);
			}
			treeNode.Name = "-" + Global.arrDatabaseLocation.Count.ToString();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000E98C File Offset: 0x0000CB8C
		public void setToolTipsForSessionNode(TreeNode treeNode, Session sess)
		{
			if (sess.sessionUserName != "")
			{
				treeNode.ToolTipText = string.Concat(new string[]
				{
					sess.sessionUserName,
					"@",
					sess.sessionHost,
					" (",
					sess.sessionProtocol,
					"/",
					sess.sessionPort.ToString(),
					")"
				});
			}
			else
			{
				treeNode.ToolTipText = string.Concat(new string[]
				{
					sess.sessionHost,
					" (",
					sess.sessionProtocol,
					"/",
					sess.sessionPort.ToString(),
					")"
				});
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000EA64 File Offset: 0x0000CC64
		public void loadDatabaseFromXMLFile(string fileName, TreeView treeView)
		{
			XmlTextReader xmlTextReader = null;
			TreeNode treeNode = null;
			try
			{
				treeView.BeginUpdate();
				xmlTextReader = new XmlTextReader(fileName);
				TreeNode treeNode2 = null;
				while (xmlTextReader.Read())
				{
					if (xmlTextReader.NodeType == XmlNodeType.Element)
					{
						if (xmlTextReader.Name == "root" || xmlTextReader.Name == "container" || xmlTextReader.Name == "connection")
						{
							TreeNode treeNode3 = new TreeNode();
							bool isEmptyElement = xmlTextReader.IsEmptyElement;
							this.setContextMenuForNode(treeNode3, xmlTextReader.Name);
							int attributeCount = xmlTextReader.AttributeCount;
							if (attributeCount > 0)
							{
								for (int i = 0; i < attributeCount; i++)
								{
									xmlTextReader.MoveToAttribute(i);
									this.SetAttributeValue(treeNode3, xmlTextReader.Name, xmlTextReader.Value);
								}
								xmlTextReader.MoveToElement();
							}
							if (xmlTextReader.Name == "root")
							{
								this.createDatabaseIDAndLocation(treeNode3, fileName);
								treeNode3.ImageIndex = 0;
								treeNode3.SelectedImageIndex = 0;
								treeNode = treeNode3;
							}
							else if (xmlTextReader.Name == "container")
							{
								treeNode3.Name = "0";
								treeNode3.ImageIndex = 1;
								treeNode3.SelectedImageIndex = 1;
							}
							else
							{
								treeNode3.ImageIndex = 2;
								treeNode3.SelectedImageIndex = 2;
								Session sess = new Session();
								this.createSession(treeNode3, sess, xmlTextReader);
								this.setToolTipsForSessionNode(treeNode3, sess);
							}
							if (treeNode2 != null)
							{
								treeNode2.Nodes.Add(treeNode3);
							}
							else
							{
								treeView.Nodes.Add(treeNode3);
							}
							if (!isEmptyElement)
							{
								treeNode2 = treeNode3;
							}
						}
					}
					if (xmlTextReader.NodeType == XmlNodeType.EndElement)
					{
						if (xmlTextReader.Name == "root" || xmlTextReader.Name == "container" || xmlTextReader.Name == "connection")
						{
							treeNode2 = treeNode2.Parent;
						}
					}
					else if (xmlTextReader.NodeType != XmlNodeType.XmlDeclaration)
					{
						if (xmlTextReader.NodeType == XmlNodeType.None)
						{
							break;
						}
						if (xmlTextReader.NodeType == XmlNodeType.Text)
						{
						}
					}
				}
			}
			finally
			{
				treeView.EndUpdate();
				this.expandTreeNode(treeNode);
				this.treeSessions.SelectedNode = treeNode;
				xmlTextReader.Close();
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000ED24 File Offset: 0x0000CF24
		public void SetAttributeValue(TreeNode treeNode, string attributeName, string value)
		{
			if (!(attributeName == "type"))
			{
				if (attributeName == "name")
				{
					treeNode.Text = value;
				}
				else if (attributeName == "expanded")
				{
					if (value == "True")
					{
						treeNode.Tag = "True";
					}
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000ED98 File Offset: 0x0000CF98
		public void createDatabaseFromPuttySessions()
		{
			try
			{
				TreeNode treeNode = new TreeNode();
				treeNode.Text = "PuTTY Sessions";
				this.createDatabaseIDAndLocation(treeNode, "");
				this.setContextMenuForNode(treeNode, "root");
				treeNode.ImageIndex = 0;
				treeNode.SelectedImageIndex = 0;
				this.treeSessions.Nodes.Add(treeNode);
				for (int i = 0; i < Global.arrPuttySessionsList.Count; i++)
				{
					PuttySession puttySession = Global.arrPuttySessionsList[i] as PuttySession;
					if (puttySession.sessionHost != "")
					{
						TreeNode treeNode2 = new TreeNode();
						treeNode2.ImageIndex = 2;
						treeNode2.SelectedImageIndex = 2;
						this.setContextMenuForNode(treeNode2, "connection");
						Session session = new Session();
						session.sessionName = puttySession.sessionName;
						session.sessionHost = puttySession.sessionHost;
						session.sessionPort = puttySession.portNumber;
						session.sessionProtocol = puttySession.protocol;
						session.sessionUserName = puttySession.userName;
						Global.arrAvailableSessions.Add(session);
						session.sessionID = Global.arrAvailableSessions.Count;
						treeNode2.Name = session.sessionID.ToString();
						treeNode2.Text = session.sessionName;
						this.setToolTipsForSessionNode(treeNode2, session);
						treeNode.Nodes.Add(treeNode2);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000EF38 File Offset: 0x0000D138
		public void saveDatabaseToXMLFile(string fileName, TreeNode treeNode)
		{
			try
			{
				XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, Encoding.UTF8);
				xmlTextWriter.WriteStartDocument();
				xmlTextWriter.WriteRaw("\r\n");
				xmlTextWriter.WriteStartElement("root");
				xmlTextWriter.WriteAttributeString("type", "database");
				xmlTextWriter.WriteAttributeString("name", treeNode.Text);
				string value = "False";
				if (treeNode.IsExpanded)
				{
					value = "True";
				}
				xmlTextWriter.WriteAttributeString("expanded", value);
				this.SaveNodes(treeNode.Nodes, xmlTextWriter);
				xmlTextWriter.WriteRaw("\r\n");
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		public void SaveNodes(TreeNodeCollection nodesCollection, XmlTextWriter writer)
		{
			try
			{
				for (int i = 0; i < nodesCollection.Count; i++)
				{
					string value = "False";
					writer.WriteRaw("\r\n");
					writer.WriteRaw("\t");
					TreeNode treeNode = nodesCollection[i];
					if (int.Parse(treeNode.Name) == 0)
					{
						writer.WriteStartElement("container");
						writer.WriteAttributeString("type", "folder");
						writer.WriteAttributeString("name", treeNode.Text);
						if (treeNode.IsExpanded)
						{
							value = "True";
						}
						writer.WriteAttributeString("expanded", value);
					}
					else if (int.Parse(treeNode.Name) > 0)
					{
						writer.WriteRaw("\t");
						writer.WriteStartElement("connection");
						writer.WriteAttributeString("type", "PuTTY");
						writer.WriteAttributeString("name", treeNode.Text);
						Session sess = this.findSessionFromAvailableSessions(int.Parse(treeNode.Name));
						this.saveSession(sess, writer);
					}
					if (treeNode.Nodes.Count > 0)
					{
						writer.WriteRaw("\t");
						this.SaveNodes(treeNode.Nodes, writer);
					}
					writer.WriteRaw("\r\n");
					writer.WriteRaw("\t");
					writer.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
		public void saveSession(Session sess, XmlTextWriter writer)
		{
			try
			{
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("name");
				writer.WriteValue(sess.sessionName);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("protocol");
				writer.WriteValue(sess.sessionProtocol);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("host");
				writer.WriteValue(sess.sessionHost);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("port");
				writer.WriteValue(sess.sessionPort.ToString());
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("session");
				writer.WriteValue(sess.sessionConfig);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("description");
				writer.WriteValue(sess.sessionDescription);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("login");
				writer.WriteValue(sess.sessionUserName);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("password");
				writer.WriteValue(sess.sessionPassword);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("connectiontimeout");
				writer.WriteValue(sess.connectionTimeout.ToString());
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("logintimeout");
				writer.WriteValue(sess.usernameTimeout.ToString());
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("passwordtimeout");
				writer.WriteValue(sess.passwordTimeout.ToString());
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("commandtimeout");
				writer.WriteValue(sess.commandTimeout.ToString());
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("command1");
				if (sess.postLoginCommands.Count > 0)
				{
					writer.WriteValue(sess.postLoginCommands[0].ToString());
				}
				else
				{
					writer.WriteValue("");
				}
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("command2");
				if (sess.postLoginCommands.Count > 1)
				{
					writer.WriteValue(sess.postLoginCommands[1].ToString());
				}
				else
				{
					writer.WriteValue("");
				}
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("command3");
				if (sess.postLoginCommands.Count > 2)
				{
					writer.WriteValue(sess.postLoginCommands[2].ToString());
				}
				else
				{
					writer.WriteValue("");
				}
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("command4");
				if (sess.postLoginCommands.Count > 3)
				{
					writer.WriteValue(sess.postLoginCommands[3].ToString());
				}
				else
				{
					writer.WriteValue("");
				}
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("command5");
				if (sess.postLoginCommands.Count > 4)
				{
					writer.WriteValue(sess.postLoginCommands[4].ToString());
				}
				else
				{
					writer.WriteValue("");
				}
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("postcommands");
				writer.WriteValue(sess.postLogin.ToString());
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("ftpusername");
				writer.WriteValue(sess.ftpUserName);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("ftppassword");
				writer.WriteValue(sess.ftpPassword);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("sftpusername");
				writer.WriteValue(sess.sftpUserName);
				writer.WriteEndElement();
				writer.WriteRaw("\r\n");
				writer.WriteRaw("\t\t\t");
				writer.WriteStartElement("sftppassword");
				writer.WriteValue(sess.sftpPassword);
				writer.WriteEndElement();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		public void setContextMenuForNode(TreeNode treeNode, string nodeName)
		{
			if (nodeName == "root")
			{
				treeNode.ContextMenuStrip = this.contextForDatabase;
			}
			else if (nodeName == "container")
			{
				treeNode.ContextMenuStrip = this.contextForFolder;
			}
			else if (nodeName == "connection")
			{
				treeNode.ContextMenuStrip = this.contextForSession;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000F830 File Offset: 0x0000DA30
		public void createSession(TreeNode treeNode, Session sess, XmlTextReader reader)
		{
			if (sess != null)
			{
				try
				{
					if (Global.arrAvailableSessions == null)
					{
						Global.arrAvailableSessions = new ArrayList();
					}
					Global.arrAvailableSessions.Add(sess);
					if (Global.arrAvailableSessions == null)
					{
						sess.sessionID = 0;
					}
					else
					{
						sess.sessionID = Global.arrAvailableSessions.Count;
					}
					int sessionID = sess.sessionID;
					treeNode.Name = sessionID.ToString();
					while (reader.Read())
					{
						if (reader.NodeType == XmlNodeType.Element)
						{
							string name = reader.Name;
							switch (name)
							{
							case "name":
								reader.Read();
								sess.sessionName = reader.Value;
								break;
							case "protocol":
								reader.Read();
								sess.sessionProtocol = reader.Value;
								break;
							case "host":
								reader.Read();
								sess.sessionHost = reader.Value;
								break;
							case "port":
								reader.Read();
								sess.sessionPort = int.Parse(reader.Value);
								break;
							case "session":
								reader.Read();
								sess.sessionConfig = reader.Value;
								break;
							case "description":
								reader.Read();
								sess.sessionDescription = reader.Value;
								break;
							case "login":
								reader.Read();
								sess.sessionUserName = reader.Value;
								if (sess.sessionUserName.Contains("\r\n"))
								{
									sess.sessionUserName = "";
								}
								break;
							case "password":
								reader.Read();
								sess.sessionPassword = reader.Value;
								if (sess.sessionPassword.Contains("\r\n"))
								{
									sess.sessionPassword = "";
								}
								break;
							case "connectiontimeout":
								reader.Read();
								sess.connectionTimeout = int.Parse(reader.Value);
								break;
							case "logintimeout":
								reader.Read();
								sess.usernameTimeout = int.Parse(reader.Value);
								break;
							case "passwordtimeout":
								reader.Read();
								sess.passwordTimeout = int.Parse(reader.Value);
								break;
							case "commandtimeout":
								reader.Read();
								sess.commandTimeout = int.Parse(reader.Value);
								break;
							case "command1":
							case "command2":
							case "command3":
							case "command4":
							case "command5":
								reader.Read();
								if (!reader.Value.Contains("\r\n"))
								{
									sess.postLoginCommands.Add(reader.Value);
								}
								break;
							case "postcommands":
								reader.Read();
								sess.postLogin = bool.Parse(reader.Value);
								break;
							case "ftpusername":
								reader.Read();
								sess.ftpUserName = reader.Value;
								if (sess.ftpUserName.Contains("\r\n"))
								{
									sess.ftpUserName = "";
								}
								break;
							case "ftppassword":
								reader.Read();
								sess.ftpPassword = reader.Value;
								if (sess.ftpPassword.Contains("\r\n"))
								{
									sess.ftpPassword = "";
								}
								break;
							case "sftpusername":
								reader.Read();
								sess.sftpUserName = reader.Value;
								if (sess.sftpUserName.Contains("\r\n"))
								{
									sess.sftpUserName = "";
								}
								break;
							case "sftppassword":
								reader.Read();
								sess.sftpPassword = reader.Value;
								if (sess.sftpPassword.Contains("\r\n"))
								{
									sess.sftpPassword = "";
								}
								break;
							}
						}
						else if (reader.NodeType == XmlNodeType.EndElement)
						{
							if (reader.Name == "connection")
							{
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000FDA8 File Offset: 0x0000DFA8
		public void expandTreeNode(TreeNode treeNode)
		{
			if (treeNode.Tag == "True")
			{
				treeNode.Expand();
			}
			for (int i = 0; i < treeNode.Nodes.Count; i++)
			{
				this.expandTreeNode(treeNode.Nodes[i]);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000FE00 File Offset: 0x0000E000
		private void contextConfigForSession_Click(object sender, EventArgs e)
		{
			frmSession frmSession = new frmSession();
			TreeNode selectedNode = this.treeSessions.SelectedNode;
			Session sess = this.findSessionFromAvailableSessions(int.Parse(this.treeSessions.SelectedNode.Name));
			frmSession.loadExistingSession(sess);
			frmSession.createOrUpdateSession = new frmSession.CreateOrUpdateSession(this.createOrUpdateSession);
			frmSession.ShowDialog();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000FE5D File Offset: 0x0000E05D
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			e.Cancel = true;
			base.Hide();
			this.hideSessionManager();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000FE84 File Offset: 0x0000E084
		private void frmSessionManager_Load(object sender, EventArgs e)
		{
			try
			{
				this.iState = 0;
				this.treeNodeCopy = null;
				this.treeNodeIsCopied = null;
				Global.arrDatabaseLocation = new ArrayList();
				if (File.Exists(Global.strDefaultDatabaseLocation))
				{
					this.loadDatabaseFromXMLFile(Global.strDefaultDatabaseLocation, this.treeSessions);
				}
				this.treeSessions.TreeViewNodeSorter = new frmSessionManager.NodeSorter();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000FF00 File Offset: 0x0000E100
		public void alertWhenDuplicateNodeName(TreeNode treeNode)
		{
			if (treeNode.Parent != null)
			{
				foreach (object obj in treeNode.Parent.Nodes)
				{
					TreeNode treeNode2 = (TreeNode)obj;
					if (treeNode2 != treeNode && treeNode2.Text == treeNode.Text)
					{
						if (int.Parse(treeNode2.Name) == 0 && int.Parse(treeNode.Name) == 0)
						{
							MessageBox.Show("This name is used for another folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							break;
						}
						if (int.Parse(treeNode2.Name) > 0 && int.Parse(treeNode.Name) > 0)
						{
							MessageBox.Show("This name is used for another session", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00010044 File Offset: 0x0000E244
		private void treeSessions_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			string oldName = e.Node.Text;
			base.BeginInvoke(new Action(delegate()
			{
				this.updateAvailableSessionAfterRenamingSessionName(e.Node, oldName);
			}));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00010090 File Offset: 0x0000E290
		public void updateAvailableSessionAfterRenamingSessionName(TreeNode treeNode, string oldName)
		{
			if (treeNode.Text.Trim() == "")
			{
				treeNode.Text = oldName;
			}
			else
			{
				if (int.Parse(treeNode.Name) > 0)
				{
					Session session = this.findSessionFromAvailableSessions(int.Parse(treeNode.Name));
					if (session != null)
					{
						session.sessionName = treeNode.Text;
					}
				}
				if (treeNode.Text != oldName)
				{
					this.alertWhenDuplicateNodeName(treeNode);
					this.treeSessions.Sort();
				}
				this.treeSessions.SelectedNode = treeNode;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001013C File Offset: 0x0000E33C
		private void contextFTPExternal_Click(object sender, EventArgs e)
		{
			Session session = this.findSessionFromAvailableSessions(int.Parse(this.treeSessions.SelectedNode.Name));
			if (session != null)
			{
				this.openExtraSession(session, "ftp");
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00010180 File Offset: 0x0000E380
		private void contextSFTPExternal_Click(object sender, EventArgs e)
		{
			Session session = this.findSessionFromAvailableSessions(int.Parse(this.treeSessions.SelectedNode.Name));
			if (session != null)
			{
				this.openExtraSession(session, "sftp");
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000101C4 File Offset: 0x0000E3C4
		private void contextConnectExternal_Click(object sender, EventArgs e)
		{
			Session session = this.findSessionFromAvailableSessions(int.Parse(this.treeSessions.SelectedNode.Name));
			if (session != null)
			{
				if (!File.Exists(Global.strPuttyLocation))
				{
					MessageBox.Show("Putty.exe file does not exist. Go to Tools -> Options... to configure PuTTY file");
				}
				else
				{
					try
					{
						string str = "";
						str = str + " -load \"" + session.sessionConfig + "\"";
						str = str + " -" + session.sessionProtocol.ToLower();
						if (session.sessionPort != -1)
						{
							str = str + " -P " + session.sessionPort.ToString();
						}
						Process process = Process.Start(new ProcessStartInfo(Global.strPuttyLocation)
						{
							Arguments = str + " " + session.sessionHost,
							UseShellExecute = false,
							CreateNoWindow = false,
							WindowStyle = ProcessWindowStyle.Hidden,
							RedirectStandardInput = true,
							RedirectStandardOutput = true,
							RedirectStandardError = true
						});
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000102F4 File Offset: 0x0000E4F4
		private void contextCreateDatabase_Click(object sender, EventArgs e)
		{
			this.createNewDatabase();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00010300 File Offset: 0x0000E500
		public string createUniqueDatabaseName(string inputName)
		{
			string text = inputName;
			int i = 0;
			int num = 2;
			string result;
			try
			{
				while (i < this.treeSessions.Nodes.Count)
				{
					if (this.treeSessions.Nodes[i].Text == text)
					{
						text = inputName + "(" + num.ToString() + ")";
						num++;
						i = -1;
					}
					i++;
				}
				result = text;
			}
			catch (Exception ex)
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001039C File Offset: 0x0000E59C
		public void createNewDatabase()
		{
			try
			{
				TreeNode treeNode = new TreeNode();
				this.createDatabaseIDAndLocation(treeNode, "");
				treeNode.Text = this.createUniqueDatabaseName("New database");
				treeNode.ContextMenuStrip = this.contextForDatabase;
				treeNode.ImageIndex = 0;
				treeNode.SelectedImageIndex = 0;
				treeNode.EnsureVisible();
				this.treeSessions.Nodes.Add(treeNode);
				MessageBox.Show("Database is created successfully!", treeNode.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				treeNode.BeginEdit();
				this.treeSessions.SelectedNode = treeNode;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00010448 File Offset: 0x0000E648
		public void copyNode(TreeNode treeNode)
		{
			try
			{
				if (this.iState == 2)
				{
					if (this.treeNodeIsCopied != null)
					{
						if (int.Parse(this.treeNodeIsCopied.Name) > 0)
						{
							this.treeNodeIsCopied.ImageIndex = 2;
							this.treeNodeIsCopied.SelectedImageIndex = 2;
						}
						else
						{
							this.treeNodeIsCopied.ImageIndex = 1;
							this.treeNodeIsCopied.SelectedImageIndex = 1;
						}
					}
				}
				this.iState = 1;
				this.treeNodeIsCopied = treeNode;
				this.treeNodeCopy = (TreeNode)this.treeNodeIsCopied.Clone();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0001050C File Offset: 0x0000E70C
		public void cutNode(TreeNode treeNode)
		{
			try
			{
				if (this.treeNodeIsCopied != null)
				{
					if (int.Parse(this.treeNodeIsCopied.Name) > 0)
					{
						this.treeNodeIsCopied.ImageIndex = 2;
						this.treeNodeIsCopied.SelectedImageIndex = 2;
					}
					else
					{
						this.treeNodeIsCopied.ImageIndex = 1;
						this.treeNodeIsCopied.SelectedImageIndex = 1;
					}
				}
				this.iState = 2;
				this.treeNodeIsCopied = treeNode;
				this.treeNodeCopy = (TreeNode)this.treeNodeIsCopied.Clone();
				if (int.Parse(treeNode.Name) > 0)
				{
					treeNode.ImageIndex = 3;
					treeNode.SelectedImageIndex = 3;
				}
				else
				{
					treeNode.ImageIndex = 4;
					treeNode.SelectedImageIndex = 4;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000105F8 File Offset: 0x0000E7F8
		public void clearCopyOrCut()
		{
			try
			{
				if (this.treeNodeIsCopied != null)
				{
					if (int.Parse(this.treeNodeIsCopied.Name) > 0)
					{
						this.treeNodeIsCopied.ImageIndex = 2;
						this.treeNodeIsCopied.SelectedImageIndex = 2;
					}
					else
					{
						this.treeNodeIsCopied.ImageIndex = 1;
						this.treeNodeIsCopied.SelectedImageIndex = 1;
					}
				}
				this.iState = 0;
				this.treeNodeCopy = null;
				this.treeNodeIsCopied = null;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00010698 File Offset: 0x0000E898
		public void pasteNode(TreeNode treeNode)
		{
			if (int.Parse(treeNode.Name) <= 0)
			{
				if (this.iState != 0 && this.treeNodeCopy != null)
				{
					if (this.treeNodeIsCopied != treeNode)
					{
						try
						{
							if (this.iState == 2 && this.treeNodeIsCopied != null)
							{
								this.treeSessions.Nodes.Remove(this.treeNodeIsCopied);
							}
							TreeNode treeNode2 = (TreeNode)this.treeNodeCopy.Clone();
							if (int.Parse(treeNode2.Name) == 0)
							{
								treeNode2.Text = this.createUniqueNodeName(treeNode, treeNode2.Text, "folder");
							}
							else
							{
								treeNode2.Text = this.createUniqueNodeName(treeNode, treeNode2.Text, "session");
							}
							treeNode.Nodes.Add(treeNode2);
							this.cloneAllSessionsInTreeNode(treeNode2);
							treeNode.Expand();
							if (this.iState == 2)
							{
								this.iState = 0;
							}
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000107D4 File Offset: 0x0000E9D4
		public void deleteNode(TreeNode treeNode)
		{
			if (treeNode != null)
			{
				if (treeNode.Parent != null)
				{
					try
					{
						string caption;
						if (int.Parse(treeNode.Name) > 0)
						{
							caption = "Delete Session";
						}
						else
						{
							caption = "Delete Folder";
						}
						DialogResult dialogResult = MessageBox.Show("Do you really want to delete " + treeNode.Text + "?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (dialogResult == DialogResult.Yes)
						{
							this.treeSessions.Nodes.Remove(treeNode);
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00010884 File Offset: 0x0000EA84
		public void cloneAllSessionsInTreeNode(TreeNode treeNode)
		{
			try
			{
				if (int.Parse(treeNode.Name) > 0)
				{
					Session fromSession = this.findSessionFromAvailableSessions(int.Parse(treeNode.Name));
					Session session = new Session();
					session.copySession(fromSession);
					Global.arrAvailableSessions.Add(session);
					session.sessionID = Global.arrAvailableSessions.Count;
					session.sessionName = treeNode.Text;
					treeNode.Name = session.sessionID.ToString();
				}
				else
				{
					for (int i = 0; i < treeNode.Nodes.Count; i++)
					{
						this.cloneAllSessionsInTreeNode(treeNode.Nodes[i]);
						if (treeNode.Nodes[i].Tag == "True")
						{
							treeNode.Nodes[i].Expand();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00010990 File Offset: 0x0000EB90
		public void renameNode(TreeNode treeNode)
		{
			if (treeNode != null)
			{
				if (treeNode.Parent != null)
				{
					treeNode.BeginEdit();
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000109C4 File Offset: 0x0000EBC4
		public string getDatabaseLocation(int databaseID)
		{
			int num = -databaseID;
			string result;
			if (Global.arrDatabaseLocation.Count < num)
			{
				result = "";
			}
			else
			{
				string text = Global.arrDatabaseLocation[num - 1].ToString();
				result = text;
			}
			return result;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00010A10 File Offset: 0x0000EC10
		public void setDatabaseLocation(int databaseID, string location)
		{
			int num = -databaseID;
			if (Global.arrDatabaseLocation.Count >= num)
			{
				Global.arrDatabaseLocation[num - 1] = location;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00010A48 File Offset: 0x0000EC48
		public string getFileNameToSave(string fileName)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Database Files (*.dat)|*.dat";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\Databases";
			saveFileDialog.FileName = fileName;
			string result;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = saveFileDialog.FileName;
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		public void saveDatabase(TreeNode treeNode)
		{
			if (treeNode != null)
			{
				try
				{
					if (treeNode.Parent == null && int.Parse(treeNode.Name) < 0)
					{
						string text = this.getDatabaseLocation(int.Parse(treeNode.Name));
						if (text != "")
						{
							this.saveDatabaseToXMLFile(text, treeNode);
						}
						else
						{
							text = this.getFileNameToSave(treeNode.Text);
							if (text != "")
							{
								this.setDatabaseLocation(int.Parse(treeNode.Name), text);
								this.saveDatabaseToXMLFile(text, treeNode);
							}
						}
						if (Global.strDefaultDatabaseLocation == "")
						{
							Global.strDefaultDatabaseLocation = text;
							Global.saveDefaultDatabaseLocationToRegistry();
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		public void saveAllDatabases()
		{
			for (int i = 0; i < this.treeSessions.Nodes.Count; i++)
			{
				TreeNode treeNode = this.treeSessions.Nodes[i];
				if (this.getDatabaseLocation(int.Parse(treeNode.Name)) == "")
				{
					DialogResult dialogResult = MessageBox.Show("Do you want to save " + treeNode.Text + "?", "Save database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (dialogResult == DialogResult.Yes)
					{
						this.saveDatabase(treeNode);
					}
				}
				else
				{
					this.saveDatabase(treeNode);
				}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00010C58 File Offset: 0x0000EE58
		public void renameDatabase(string dbID, string dbName)
		{
			for (int i = 0; i < this.treeSessions.Nodes.Count; i++)
			{
				if (this.treeSessions.Nodes[i].Name == dbID)
				{
					this.treeSessions.Nodes[i].Text = dbName;
					TreeNode selectedNode = this.treeSessions.Nodes[i];
					this.treeSessions.Sort();
					this.treeSessions.SelectedNode = selectedNode;
					break;
				}
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		public void openAllSessionsInFolder(TreeNode treeNode)
		{
			try
			{
				for (int i = 0; i < treeNode.Nodes.Count; i++)
				{
					if (int.Parse(treeNode.Nodes[i].Name) > 0)
					{
						Session session = this.findSessionFromAvailableSessions(int.Parse(treeNode.Nodes[i].Name));
						if (session != null)
						{
							this.openSession(session);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00010D8C File Offset: 0x0000EF8C
		private void contextDeleteForSession_Click(object sender, EventArgs e)
		{
			this.deleteNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00010DA1 File Offset: 0x0000EFA1
		private void contextCopyForSession_Click(object sender, EventArgs e)
		{
			this.copyNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00010DB6 File Offset: 0x0000EFB6
		private void contextCutForSession_Click(object sender, EventArgs e)
		{
			this.cutNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00010DCB File Offset: 0x0000EFCB
		private void contextRenameForSession_Click(object sender, EventArgs e)
		{
			this.renameNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		private void contextPasteForFolder_Click(object sender, EventArgs e)
		{
			this.pasteNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00010DF5 File Offset: 0x0000EFF5
		private void contextCutForFolder_Click(object sender, EventArgs e)
		{
			this.cutNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00010E0A File Offset: 0x0000F00A
		private void contextCopyForFolder_Click(object sender, EventArgs e)
		{
			this.copyNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00010E1F File Offset: 0x0000F01F
		private void contextDeleteForFolder_Click(object sender, EventArgs e)
		{
			this.deleteNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00010E34 File Offset: 0x0000F034
		private void contextForFolder_Opening(object sender, CancelEventArgs e)
		{
			if (this.iState == 0)
			{
				this.contextPasteForFolder.Enabled = false;
			}
			else
			{
				this.contextPasteForFolder.Enabled = true;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00010E6E File Offset: 0x0000F06E
		private void contextRenameForFolder_Click(object sender, EventArgs e)
		{
			this.renameNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00010E83 File Offset: 0x0000F083
		private void contextConnectAllForFolder_Click(object sender, EventArgs e)
		{
			this.openAllSessionsInFolder(this.treeSessions.SelectedNode);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00010E98 File Offset: 0x0000F098
		private void contextPasteForDatabase_Click(object sender, EventArgs e)
		{
			this.pasteNode(this.treeSessions.SelectedNode);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		private void contextForDatabase_Opening(object sender, CancelEventArgs e)
		{
			try
			{
				if (this.iState == 0)
				{
					this.contextPasteForDatabase.Enabled = false;
				}
				else
				{
					this.contextPasteForDatabase.Enabled = true;
				}
				TreeNode selectedNode = this.treeSessions.SelectedNode;
				string databaseLocation = this.getDatabaseLocation(int.Parse(selectedNode.Name));
				if (databaseLocation != Global.strDefaultDatabaseLocation)
				{
					this.contextSetDefaultForDatabase.Enabled = true;
				}
				else
				{
					this.contextSetDefaultForDatabase.Enabled = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00010F50 File Offset: 0x0000F150
		private void contextSaveForDatabase_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = this.treeSessions.SelectedNode;
			this.saveDatabase(selectedNode);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00010F74 File Offset: 0x0000F174
		private void contextPropertiesForDatabase_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = this.treeSessions.SelectedNode;
			string databaseLocation = this.getDatabaseLocation(int.Parse(selectedNode.Name));
			new frmDatabaseProperties(selectedNode.Name, selectedNode.Text, databaseLocation)
			{
				renameDatabase = new frmDatabaseProperties.RenameDatabase(this.renameDatabase)
			}.ShowDialog();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00010FCC File Offset: 0x0000F1CC
		private void contextSetDefaultForDatabase_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = this.treeSessions.SelectedNode;
			string databaseLocation = this.getDatabaseLocation(int.Parse(selectedNode.Name));
			if (databaseLocation != Global.strDefaultDatabaseLocation)
			{
				Global.strDefaultDatabaseLocation = databaseLocation;
				Global.saveDefaultDatabaseLocationToRegistry();
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00011018 File Offset: 0x0000F218
		private void treeSessions_KeyPress(object sender, KeyPressEventArgs e)
		{
			char keyChar = e.KeyChar;
			if (keyChar != '\r')
			{
				if (keyChar == '\u001b')
				{
					this.clearCopyOrCut();
				}
			}
			else
			{
				int num = int.Parse(this.treeSessions.SelectedNode.Name);
				if (num > 0)
				{
					Session session = this.findSessionFromAvailableSessions(num);
					if (session != null)
					{
						this.openSession(session);
					}
				}
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00011088 File Offset: 0x0000F288
		private void treeSessions_KeyDown(object sender, KeyEventArgs e)
		{
			TreeNode selectedNode = this.treeSessions.SelectedNode;
			if (selectedNode != null)
			{
				try
				{
					if (e.Modifiers == Keys.Control)
					{
						Keys keyCode = e.KeyCode;
						if (keyCode != Keys.C)
						{
							switch (keyCode)
							{
							case Keys.V:
								this.pasteNode(selectedNode);
								break;
							case Keys.X:
								if (selectedNode.Parent != null)
								{
									this.cutNode(selectedNode);
								}
								break;
							}
						}
						else if (selectedNode.Parent != null)
						{
							this.copyNode(selectedNode);
						}
					}
					else if (e.KeyCode == Keys.Delete)
					{
						this.deleteNode(this.treeSessions.SelectedNode);
					}
					else if (e.KeyCode == Keys.F2)
					{
						this.renameNode(this.treeSessions.SelectedNode);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00011198 File Offset: 0x0000F398
		private void contextCloseDatabaseForDatabase_Click(object sender, EventArgs e)
		{
			try
			{
				TreeNode selectedNode = this.treeSessions.SelectedNode;
				string databaseLocation = this.getDatabaseLocation(int.Parse(selectedNode.Name));
				DialogResult dialogResult = MessageBox.Show("Do you really want to close this database?", "Close database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult != DialogResult.No)
				{
					this.saveDatabase(selectedNode);
					this.treeSessions.Nodes.Remove(selectedNode);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001121C File Offset: 0x0000F41C
		private void frmSessionManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.saveAllDatabases();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00011228 File Offset: 0x0000F428
		private void treeSessions_AfterSelect(object sender, TreeViewEventArgs e)
		{
			try
			{
				TreeNode selectedNode = this.treeSessions.SelectedNode;
				int num = int.Parse(selectedNode.Name);
				string text;
				if (num > 0)
				{
					Session session = this.findSessionFromAvailableSessions(num);
					if (session.sessionUserName != "")
					{
						text = string.Concat(new string[]
						{
							"Session - ",
							session.sessionUserName,
							"@",
							session.sessionHost,
							" (",
							session.sessionProtocol,
							"/",
							session.sessionPort.ToString(),
							")"
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							"Session - ",
							session.sessionHost,
							" (",
							session.sessionProtocol,
							"/",
							session.sessionPort.ToString(),
							")"
						});
					}
				}
				else if (num == 0)
				{
					text = "Folder - " + selectedNode.Text;
				}
				else
				{
					text = "Database - " + selectedNode.Text;
				}
				this.displayStatus(text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040000ED RID: 237
		private const int IS_COPY = 1;

		// Token: 0x040000EE RID: 238
		private const int IS_CUT = 2;

		// Token: 0x040000EF RID: 239
		private const int IS_NONE = 0;

		// Token: 0x040000F0 RID: 240
		private const int INDEX_DATABASE = 0;

		// Token: 0x040000F1 RID: 241
		private const int INDEX_FOLDER = 1;

		// Token: 0x040000F2 RID: 242
		private const int INDEX_FOLDER_CUT = 4;

		// Token: 0x040000F3 RID: 243
		private const int INDEX_SESSION = 2;

		// Token: 0x040000F4 RID: 244
		private const int INDEX_SESSION_CUT = 3;

		// Token: 0x040000F5 RID: 245
		private TreeNode treeNodeCopy;

		// Token: 0x040000F6 RID: 246
		private TreeNode treeNodeIsCopied;

		// Token: 0x040000F7 RID: 247
		private int iState;

		// Token: 0x040000F8 RID: 248
		public frmSessionManager.OpenSession openSession;

		// Token: 0x040000F9 RID: 249
		public frmSessionManager.HideSessionManager hideSessionManager;

		// Token: 0x040000FA RID: 250
		public frmSessionManager.OpenExtraSession openExtraSession;

		// Token: 0x040000FB RID: 251
		public frmSessionManager.DisplayStatus displayStatus;

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000139 RID: 313
		public delegate void OpenSession(Session sess);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600013D RID: 317
		public delegate void HideSessionManager();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000141 RID: 321
		public delegate void OpenExtraSession(Session sess, string type);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000145 RID: 325
		public delegate void DisplayStatus(string text);

		// Token: 0x02000015 RID: 21
		public class NodeSorter : IComparer
		{
			// Token: 0x06000148 RID: 328 RVA: 0x00012634 File Offset: 0x00010834
			public int Compare(object x, object y)
			{
				TreeNode treeNode = x as TreeNode;
				TreeNode treeNode2 = y as TreeNode;
				try
				{
					if (int.Parse(treeNode.Name) > 0 && int.Parse(treeNode2.Name) > 0)
					{
						return string.Compare(treeNode.Text, treeNode2.Text);
					}
					if (int.Parse(treeNode.Name) <= 0 && int.Parse(treeNode2.Name) <= 0)
					{
						return string.Compare(treeNode.Text, treeNode2.Text);
					}
				}
				catch (Exception ex)
				{
				}
				return int.Parse(treeNode.Name) - int.Parse(treeNode2.Name);
			}
		}
	}
}
