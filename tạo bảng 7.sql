
USE PolyLearnAI;
GO

CREATE TABLE Languages (
    LanguageID INT IDENTITY(1,1) PRIMARY KEY,
    LanguageCode VARCHAR(10) NOT NULL UNIQUE,
    LanguageName NVARCHAR(100) NOT NULL
);
GO

INSERT INTO Languages (LanguageCode, LanguageName)
VALUES
('en', N'Tiếng Anh'),
('zh', N'Tiếng Trung'),
('ja', N'Tiếng Nhật'),
('ko', N'Tiếng Hàn'),
('fr', N'Tiếng Pháp'),
('de', N'Tiếng Đức'),
('es', N'Tiếng Tây Ban Nha');
GO

SELECT * FROM Languages;
