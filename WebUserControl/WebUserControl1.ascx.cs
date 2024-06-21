using System;

namespace WebUserControl
{
    /// <summary>
    /// ユーザーコントロールの処理クラス
    /// </summary>
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        /// <summary>
        /// このユーザーコントロールの「ボタン1がクリックされた」ときに発生するイベントをハンドリングするメソッドの定義
        /// </summary>
        public delegate void OnButton1ClickEventHandler();

        /// <summary>
        /// ユーザーコントロールの「ボタン1がクリックされた」イベント
        /// </summary>
        public event OnButton1ClickEventHandler OnButton1Click = null;

        /// <summary>
        /// 「ボタン1」がクリックされた際に呼び出されるイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = "WebUserControl1.Button1_Clickが呼び出されました";

            //「ボタン1がクリックされた」ときに発生させるイベントにハンドラが設定されていればハンドラを呼び出す
            if (this.OnButton1Click is OnButton1ClickEventHandler)
            {
                this.OnButton1Click.Invoke();
            }
        }

        /// <summary>
        /// ページがロードされたときに呼び出されるイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}