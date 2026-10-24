
USE PolyLearnAI;
GO

IF OBJECT_ID('dbo.Vocabulary', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Vocabulary (
        VocabularyID INT IDENTITY(1,1) PRIMARY KEY,
        LanguageID INT NOT NULL,
        Word NVARCHAR(255) NOT NULL,
        Pronunciation NVARCHAR(255),
        MeaningVietnamese NVARCHAR(MAX),
        ExampleSentence NVARCHAR(MAX),
        ExampleTranslation NVARCHAR(MAX),
        Topic NVARCHAR(100),
        Level NVARCHAR(20),
        SourceName NVARCHAR(150),
        CreatedAt DATETIME2 DEFAULT SYSDATETIME(),

        CONSTRAINT FK_Vocabulary_Languages
        FOREIGN KEY (LanguageID)
        REFERENCES dbo.Languages(LanguageID)
    );
END;
GO

SELECT * FROM dbo.Vocabulary;
