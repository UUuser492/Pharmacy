CREATE PROCEDURE [dbo].[ForType]
	@type nvarchar(50) OUTPUT
AS
	SELECT @type = [Type] FROM Drugs WHERE Price = (SELECT MAX(Price) FROM Drugs)
RETURN 0
