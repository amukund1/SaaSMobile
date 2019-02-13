using System;
using System.Collections.Generic;

using UIKit;

using SaaSMobile;
using Foundation;

namespace saasmobile.ios
{
    public partial class StudiesViewController : UIViewController
    {
        public StudiesViewController() : base("StudiesViewController", null)
        {
        }

        protected internal StudiesViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if (MockParticipantStudyLists.Size() == 0)
            {
                return;
            }

            StudyParticipant curParticipant = MockStudyParticipantTable.CurrentParticipant;

            var registeredStudies = MockParticipantStudyLists.GetParticipantRegisteredStudies(curParticipant);
            var studiesList = ToList(registeredStudies);

            var source = new RegisteredStudiesDatasource(studiesList);

            RegisteredStudiesTableView.Source = source;

        }

        private List<Study> ToList(HashSet<Study> studies)
        {
            List<Study> studiesList = new List<Study>();
            foreach (Study study in studies)
            {
                studiesList.Add(study);
            }
            return studiesList;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier.Equals("joinStudySegue"))
            {
                return;
            }

            RegisteredStudiesDatasource source = (RegisteredStudiesDatasource) RegisteredStudiesTableView.Source;
            var study = source.GetStudy(RegisteredStudiesTableView.IndexPathForSelectedRow.Row);

            if (segue.Identifier.Equals("selectedStudySegue"))
            {
                var target = (SelectedStudyDetailViewController) segue.DestinationViewController;
                target.SetSelectedStudy(study);

            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

