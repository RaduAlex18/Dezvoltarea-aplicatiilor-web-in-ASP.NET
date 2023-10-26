INSERT INTO [students] (Id, DateTime, LastModified, Name, Age, zile_traite)
VALUES (NEWID(), GETDATE(), GETDATE(), 'Eu', 20, 365);

select * from Students;