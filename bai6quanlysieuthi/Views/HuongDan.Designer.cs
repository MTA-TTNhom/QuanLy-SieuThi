namespace bai6quanlysieuthi.Views
{
    partial class HuongDan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khách hàng");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nhân viên");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hàng hóa");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hướng dẫn", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
        }

        #endregion
    }
}