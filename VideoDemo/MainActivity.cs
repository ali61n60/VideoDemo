using Android.App;
using Android.Net;
using Android.Widget;
using Android.OS;

namespace VideoDemo
{
    [Activity(Label = "VideoDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private VideoView _videoView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            initFields();
        }

        private void initFields()
        {
            _videoView = FindViewById<VideoView>(Resource.Id.videoView1);
            Uri uri = Uri.Parse("android.resource://" + PackageName + "/" +
                                Resource.Raw.video);
            _videoView.SetVideoURI(uri);
            _videoView.Start();
        }
    }
}

