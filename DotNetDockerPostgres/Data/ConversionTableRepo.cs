namespace DotNetDockerPostgres.Data
{
    public class ConversionTableRepo : IConversionTableRepo
    {
        private readonly ConversionRateDBContext _context;

        public ConversionTableRepo(ConversionRateDBContext context)
        {
            _context = context;
        }

        public void CreateConversionUnit(Unit unit)
        {
            if(unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            _context.Units.Add(unit);
        }

        public IEnumerable<Unit> GetAllConversionUnit()
        {
            return _context.Units.ToList();
        }

        public Unit GetConversionUnitById(int id)
        {
            return _context.Units.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
