namespace FormularioNOW.Context
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NowContext : DbContext
    {
        public NowContext()
            : base("name=NowContext")
        {
        }
        public virtual DbSet<NOW> Now { get; set; }
    }
}