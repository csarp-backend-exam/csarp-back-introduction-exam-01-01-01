using FociProjekt.Context;

namespace FociProjekt.Repos
{
    public class FociKlubokRepo
    {
        // Kapcsolat a Context és a Repo réteg között
        private AppDbContext _appDbContext;
        public FociKlubokRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
