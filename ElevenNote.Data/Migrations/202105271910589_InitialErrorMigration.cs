namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialErrorMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Note", "CretedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "CretedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.Note", "CreatedUtc");
        }
    }
}
