using ChatAppModelsLibrary.Models.Concrets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace ChatAppDatabaseLibraryy.Configurations
{
    public class GroupAndUserConfiguration : IEntityTypeConfiguration<GroupAndUser>
    {
        public void Configure(EntityTypeBuilder<GroupAndUser> builder)
        {
            builder.HasOne(gu => gu.User)
                .WithMany(u => u.GroupAndUsers)
                .HasForeignKey(gu => gu.UserId);

            builder.HasOne(gu => gu.Group)
              .WithMany(g => g.GroupAndUsers)
              .HasForeignKey(gu => gu.GroupId);
        }
    }
}
