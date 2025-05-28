using Template.Services.Shared;
using System;
using System.Linq;
using Template.Services;

namespace Template.Infrastructure
{
    public class DataGenerator
    {
        public static void InitializeUsers(TemplateDbContext context)
        {
            if (context.Users.Any())
            {
                return;   // Data was already seeded
            }

            context.Users.AddRange(
                new User
                {
                    Id = Guid.Parse("3de6883f-9a0b-4667-aa53-0fbc52c4d300"),
                    Email = "mario.rossi@example.com",
                    Password = "M0Cuk9OsrcS/rTLGf5SY6DUPqU2rGc1wwV2IL88GVGo=", // SHA-256 di "Prova"
                    FirstName = "Mario",
                    LastName = "Rossi",
                    NickName = "Marione"
                },
                new User
                {
                    Id = Guid.Parse("a030ee81-31c7-47d0-9309-408cb5ac0ac7"),
                    Email = "paolo.verdi@example.com",
                    Password = "Uy6qvZV0iA2/drm4zACDLCCm7BE9aCKZVQ16bg80XiU=", // SHA-256 di "Test"
                    FirstName = "Paolo",
                    LastName = "Verdi",
                    NickName = "Paolino"
                },
                new User
                {
                    Id = Guid.Parse("bfdef48b-c7ea-4227-8333-c635af267354"),
                    Email = "giovanni.storti@example.com",
                    Password = "Uy6qvZV0iA2/drm4zACDLCCm7BE9aCKZVQ16bg80XiU=", // SHA-256 di "Test"
                    FirstName = "Giovanni",
                    LastName = "Storti",
                    NickName = "Giova"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "luca.bianchi@example.com",
                    Password = "FfIrfXtZP1JeQ+btpoN9z02vYPR8JPA1y4pK2WXLJ5E=", // SHA-256 di "Password123"
                    FirstName = "Luca",
                    LastName = "Bianchi",
                    NickName = "Luc"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "francesca.neri@example.com",
                    Password = "uK2mAt6wnzCZyOgbT5MttHD8OV72qKbzS1b4sUVbaf0=", // SHA-256 di "Benvenuto!"
                    FirstName = "Francesca",
                    LastName = "Neri",
                    NickName = "Fra"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "giorgio.romano@example.com",
                    Password = "nkEVAmu2UqYrnsEUm47g8qBoOjRrWwRUJ+2B19KjPp0=", // SHA-256 di "Visitatore1"
                    FirstName = "Giorgio",
                    LastName = "Romano",
                    NickName = "Gio"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "claudia.ferri@example.com",
                    Password = "hLQrz8MIX10xzJ6D1WfJyn6+MbPHCHz95dYX2WYNK8o=", // SHA-256 di "CiaoCiao"
                    FirstName = "Claudia",
                    LastName = "Ferri",
                    NickName = "Cla"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "andrea.fontana@example.com",
                    Password = "EKWjMow46c8llqvwXVb9bICUykhNBD0bHHxU1n48CPw=", // SHA-256 di "P@ssw0rd"
                    FirstName = "Andrea",
                    LastName = "Fontana",
                    NickName = "Andy"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "ilaria.galli@example.com",
                    Password = "zqB9HD8il1+to5uMwtN0ZsmHwbzhk5G5sKYcuv6aEXc=", // SHA-256 di "Segreto!"
                    FirstName = "Ilaria",
                    LastName = "Galli",
                    NickName = "Ila"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "matteo.mancini@example.com",
                    Password = "tA1LjGylqdbBXP+1X2UQmrmHPvmUz9yAcxrMoXQWncs=", // SHA-256 di "Matteo2024"
                    FirstName = "Matteo",
                    LastName = "Mancini",
                    NickName = "Matt"
                }
            );

            context.SaveChanges();
        }
    }
}
