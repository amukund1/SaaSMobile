using System;
using System.Collections.Generic;

using UIKit;

using SaaSMobile;
using Foundation;

namespace saasmobile.ios
{
    public partial class StudiesRepositoryTableViewController : UITableViewController
    {
        public StudiesRepositoryTableViewController() : base("StudiesRepositoryTableViewController", null)
        {
        }

        protected internal StudiesRepositoryTableViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var repo = MockStudiesRepository.GetRepo();
            var source = new StudiesDatasource(repo);
            this.TableView.Source = source;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            StudiesDatasource source = (StudiesDatasource) this.TableView.Source;
            var study = source.GetStudy(this.TableView.IndexPathForSelectedRow.Row);

            if (segue.Identifier.Equals("studyDetailSegue")) {
                var target = (StudyDetailViewController) segue.DestinationViewController;
                target.SetStudy(study);
            }
        }
    }
}

