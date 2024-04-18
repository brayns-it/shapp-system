﻿namespace Brayns.System
{
    public class Authentication : Table<Authentication>
    {
        public Fields.Text ID { get; } = new("ID", Label("ID"), 2048);
        public Fields.Code UserID { get; } = new("User ID", Label("User ID"), 50);
        public Fields.DateTime CreationDateTime { get; } = new("Creation date/time", Label("Creation date/time"));
        public Fields.DateTime ExpireDateTime { get; } = new("Expire date/time", Label("Expire  date/time"));

        public Authentication()
        {
            TableName = "Authentication";
            UnitCaption = Label("Authentication");
            TablePrimaryKey.Add(ID);

            AddRelation<User>(UserID);
        }
    }
}
