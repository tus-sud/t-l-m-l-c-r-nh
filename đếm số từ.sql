SELECT
    l.LanguageName,
    COUNT(v.VocabularyID) AS SoTu
FROM dbo.Languages AS l
LEFT JOIN dbo.Vocabulary AS v
    ON l.LanguageID = v.LanguageID
GROUP BY l.LanguageName;