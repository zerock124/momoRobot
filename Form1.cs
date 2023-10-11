using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.InteropServices;

namespace momorobots
{
    public partial class Form1 : Form
    {
        private static IWebDriver? driver;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        /// <summary>
        /// 開啟瀏覽器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWeb_Click(object sender, EventArgs e)
        {
            try
            {
                // 開啟控制台視窗
                AllocConsole();
                Console.WriteLine("開啟瀏覽器, 請稍後...");
                // 開啟瀏覽器, 並跳轉至設定頁面
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                driver = new ChromeDriver(driverService);
                string url = "https://scm.momoshop.com.tw/manage/login.jsp";
                driver.Navigate().GoToUrl(url);
                Console.WriteLine("開啟瀏覽器完成");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// 執行暫緩排程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActionStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (driver != null)
                {
                    // 設定進度條從0開啟
                    progressBar.Value = 0;
                    // 總數量
                    int totalCount = 0;
                    // 取得所有需要點擊暫緩的商品
                    var totalProducts = driver.FindElements(By.CssSelector("input[name='btnNotDow']"));
                    // 取得需要執行「暫緩」的總數量
                    if (totalProducts != null)
                        totalCount = totalProducts.Count();
                    if (totalCount > 0)
                    {
                        // 執行狀態
                        bool success = false;
                        // 已經執行的數量
                        int actionCount = 0;
                        while (success == false)
                        {
                            try
                            {
                                IWebElement _btnNotDow = driver.FindElement(By.CssSelector("input[name='btnNotDow']"));
                                if (_btnNotDow != null)
                                {
                                    _btnNotDow.Click();
                                }
                                IWebElement _alertCloseBtn = driver.FindElement(By.Id("alertCloseBtn"));
                                if (_alertCloseBtn != null)
                                {
                                    _alertCloseBtn.Click();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.Write("點擊暫緩出現錯誤, 請確認異常問題");
                            }
                            actionCount++;
                            // 進度條
                            labProcess.Text = string.Format("{0} / {1}", actionCount, totalCount);
                            progressBar.Value = actionCount / totalCount;
                            if (progressBar.Value == 100)
                                success = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("無任何需要執行「暫緩」的商品");
                    }
                }
                else
                {
                    MessageBox.Show("請先開啟瀏覽器");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}