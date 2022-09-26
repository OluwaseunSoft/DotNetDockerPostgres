namespace DotNetDockerPostgres.Data
{
    public interface IConversionTableRepo
    {
        bool SaveChanges();
        IEnumerable<Unit> GetAllConversionUnit();
        Unit GetConversionUnitById(int id);
        void CreateConversionUnit(Unit unit);
    }
}
