using Clubex2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clubex2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Committee> Committees { get; set; }
        public DbSet<CommitteeMember> CommitteeMembers { get; set; }
        public DbSet<ContentSearch> ContentSearches { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Executive> Executives { get; set; }
        public DbSet<ExecutivePosition> ExecutivePositions { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingAgenda> MeetingAgendas { get; set; }
        public DbSet<Member> Members { get; set; }  
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<SmtpSetting> SmtpSettings { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }
    }
}