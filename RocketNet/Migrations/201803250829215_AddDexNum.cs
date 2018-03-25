namespace RocketNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDexNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pokemons", "DexNum", c => c.Int(nullable: false));
            AddColumn("dbo.Pokemons", "Type1", c => c.String());
            AddColumn("dbo.Pokemons", "Type2", c => c.String());
            DropColumn("dbo.Pokemons", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pokemons", "Type", c => c.String());
            DropColumn("dbo.Pokemons", "Type2");
            DropColumn("dbo.Pokemons", "Type1");
            DropColumn("dbo.Pokemons", "DexNum");
        }
    }
}
