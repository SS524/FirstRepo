namespace WebApplication10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStudentTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Students values('Soumya','abc@gmail.com',23,'Male')");
        }
        
        public override void Down()
        {
        }
    }
}
