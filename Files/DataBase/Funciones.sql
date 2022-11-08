use Financiera
go

Create function CleanInput(@input nvarchar(20))
RETURNS NVARCHAR(20)
AS
BEGIN
	DECLARE @Output nvarchar(50)
	DECLARE input CURSOR
	FOR select @Output	
	OPEN input
	SET @Output = LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(@input, char(34), ''), char(61), ''), 'select', '')))
	if(@Output = null or @Output = '')
		BEGIN
			set @Output = null
		END 
	CLOSE input
	Deallocate input
	return @Output	
END