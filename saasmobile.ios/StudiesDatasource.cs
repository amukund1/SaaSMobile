using System;
using UIKit;
using SaaSMobile;
using System.Collections.Generic;
using Foundation;

namespace saasmobile.ios
{
    public class StudiesDatasource : UITableViewSource
    {
        private List<Study> _studies;

        public StudiesDatasource(List<Study> studies)
        {
            _studies = studies;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("studyCell");
            var study = _studies[indexPath.Row];

            cell.TextLabel.Text = study.Name;
            return cell;    
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _studies.Count;
        }

        public Study GetStudy(int row)
        {
            return _studies[row];
        }
    }

}
