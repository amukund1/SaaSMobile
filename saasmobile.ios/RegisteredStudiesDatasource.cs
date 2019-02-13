using System;
using System.Collections.Generic;

using UIKit;

using SaaSMobile;
using Foundation;

namespace saasmobile.ios
{
    public class RegisteredStudiesDatasource : UITableViewSource
    {
        private List<Study> _registeredStudies;

        public RegisteredStudiesDatasource(List<Study> registeredStudies)
        {
            _registeredStudies = registeredStudies;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("registeredStudyCell");
            var study = _registeredStudies[indexPath.Row];

            cell.TextLabel.Text = study.Name;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _registeredStudies.Count;
        }

        public Study GetStudy(int row)
        {
            return _registeredStudies[row];
        }
    }
}
