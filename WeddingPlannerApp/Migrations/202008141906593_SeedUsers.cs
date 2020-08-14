namespace WeddingPlannerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'69beed0a-7609-445d-b9a7-9a713a89e022', N'guest@wedding.com', 0, N'AB410vIo2vbqhEG3aHmIYAs5cvKJ5HDLsLeMMP+4HPPPavdkZkC03jImh4ixqD3Yfw==', N'5ba5d3ff-0799-4d3d-8e94-15170203b284', NULL, 0, 0, NULL, 1, 0, N'guest@wedding.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c838f4fe-d2b8-4710-b65e-d4e52f0a3ddc', N'admin@wedding.com', 0, N'ANIqfL+3Kymtf6JDa3R46RYvkFOj+NWNDSvz5aSkwt4crvbr/qcC1hN8MD4U3wvYJw==', N'8d470ffb-2745-4947-a354-ee817b8e8bba', NULL, 0, 0, NULL, 1, 0, N'admin@wedding.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ab348cdc-d316-40e0-95db-36561e7c6bf3', N'CanManageAttendees')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c838f4fe-d2b8-4710-b65e-d4e52f0a3ddc', N'ab348cdc-d316-40e0-95db-36561e7c6bf3')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
