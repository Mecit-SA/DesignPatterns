namespace Proxy
{
    class ProductProxy : Product
    {
        private readonly DbContext _context;

        public ProductProxy(DbContext context, int id, string name)
            : base(id, name)
        {
            _context = context;
        }

        public override void UpdateName(string name)
        {
            base.UpdateName(name);
            _context.MarkAsChanged(this);
        }
    }
}