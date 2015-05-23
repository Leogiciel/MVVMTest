using IModels;

namespace DAOs
{
    public class DAO : IModel
    {
        public string Name
        {
            get
            {
                Properties.Settings.Default.Reload();
                return Properties.Settings.Default.Name;
            }
            set
            {
                Properties.Settings.Default.Name = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
