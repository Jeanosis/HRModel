using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Repositories;

namespace GraphicClient
{
    public class Presenter
    {
        public Presenter(ClientForm view, IMainRepository model)
        {
            this.view = view;
            this.model = model;
            view.RequestButtonClick += OnRequestClick;
        }

        private void OnRequestClick(string requestedName)
        {
            var candidate = model.GetCandidateByName(requestedName);
            view.QueryResult = candidate == null ? "failed" : candidate.FirstName;
        }

        private ClientForm view;
        private IMainRepository model;
    }
}
