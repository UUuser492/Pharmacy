CREATE FUNCTION [dbo].[DrugsPriceMore]
(
	@price decimal
)
RETURNS @returntable TABLE
(
	Drug_id int,
	ManufacturerId int,
	Name nvarchar(50),
	Type nvarchar(50),
	Price decimal
)
AS
BEGIN
	INSERT @returntable
	SELECT Drug_id, ManufacturerId, Name, Type, Price FROM Drugs WHERE Price > @price
	RETURN
END