using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using System.Threading;
using System.IO;


namespace YouCatch
{
    public partial class UserControl2 : UserControl
    {

        String Path;

        public static UserControl2 _instanse;
        public static UserControl2 Instance
        {
            get
            {
                if (_instanse == null)
                    _instanse = new UserControl2();
                return _instanse;

            }
        }

        public UserControl2()
        {
            InitializeComponent();
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";
            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.SelectedPath;
            }
            lblPath.Text = tempPath;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
                txtURL.Text = (String)iData.GetData(DataFormats.Text);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {/*
            string link = "https://www.youtube.com/watch?v=jIpawdg48U4";
            
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

            VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

           
            var videoDownloader = new VideoDownloader(video, System.IO.Path.Combine("D:/Song", video.Title + video.VideoExtension));

            videoDownloader.DownloadProgressChanged += (SendKeys, args) => Console.WriteLine(args.ProgressPercentage);

            videoDownloader.Execute();*/

           
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(txtURL.Text);
            VideoInfo video=videos.First(p=>p.VideoType==VideoType.Mp4&&p.Resolution==360);
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            try
            {
                VideoDownloader downloader = new VideoDownloader(video, System.IO.Path.Combine(Application.StartupPath + "\\", video.Title + video.VideoExtension));

                downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
                Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            }
            catch {
            }
   

        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
          Invoke(new MethodInvoker(delegate()
          {
              ProgressBar1.Value = (int)e.ProgressPercentage;
              pro3.Value = (int)e.ProgressPercentage;

          }));
        }
    }
}
