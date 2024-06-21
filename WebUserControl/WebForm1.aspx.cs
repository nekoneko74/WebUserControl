using System;
using System.Web.UI.WebControls;

namespace WebUserControl
{
    /// <summary>
    /// Webフォームのページクラス
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        /// <summary>
        /// フォーム上の「ボタン」がクリックされた際に呼び出されるイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "WebForm1.Button1_Clickが呼び出されました";

            // ユーザーコントロール内のテキストボックスにアクセスする
            TextBox textBox = this.UserControl1.FindControl("TextBox1") as TextBox;
            if (textBox is TextBox)
            {
                textBox.Text += "【改竄】";
            }
        }

        /// <summary>
        /// ページがロードされた際に呼び出されるイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // ユーザーコントロール上の「ボタン1」のクリックイベントをハンドリングするメソッドを設定する
            this.UserControl1.OnButton1Click += this.UserControlButton1_Click;
        }

        /// <summary>
        /// ユーザーコントロール上の「ボタン1」がクリックされた際に呼び出されるイベントハンドラ
        /// </summary>
        protected void UserControlButton1_Click()
        {
            this.TextBox1.Text = "ユーザーコントロールからクリックイベントが中継されました";
        }
    }
}