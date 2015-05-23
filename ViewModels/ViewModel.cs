using IModels;

namespace ViewModels
{
    public class ViewModel
    {
        private IModel _Model { get; set; }

        private string name;
        public string Name
        {
            get { return name ?? (name = _Model.Name); }
            set { name = value; }
        }

        public ViewModel()
        {
            _Model = DAOBuilder.Builder.GetDAO();
        }

        public void Validate()
        {
            _Model.Name = name;
        }
    }
}
