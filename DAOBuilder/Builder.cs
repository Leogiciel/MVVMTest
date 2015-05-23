using IModels;
using DAOs;

namespace DAOBuilder
{
    public static class Builder
    {
        public static IModel GetDAO()
        {
            return new DAO();
        }
    }
}
