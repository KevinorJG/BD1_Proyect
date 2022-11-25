use Financiera
go

alter function CleanInput(@input nvarchar(50))
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @Output nvarchar(50)
	DECLARE input CURSOR
	FOR select @Output	
	OPEN input
	SET @Output = LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(@input, char(34), ''), char(61), ''), 'select', '')))
	SET @Output = LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(@input, char(62), ''), char(124), ''), 'from', '')))
	SET @Output = LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(@input, char(60), ''), char(43), ''), 'where', '')))
	if(@Output = null or @Output = '')
		BEGIN
			set @Output = null
		END 
	CLOSE input
	Deallocate input
	return @Output	
END