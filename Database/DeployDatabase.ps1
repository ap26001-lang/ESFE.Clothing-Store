param(
	[string]$Server = "localhost",
	[string]$Database = "BDDesarrollo",
	[string]$Path = "$(Split-Path -Parent $MyInvocation.MyCommand.Path)"
)

$files = @(
	"CreateTable_Clientes.sql",
	"sp_Clientes_Insertar.sql",
	"sp_Clientes_Actualizar.sql",
	"sp_Clientes_Eliminar.sql"
)

foreach ($f in $files) {
	$full = Join-Path $Path $f
	if (-Not (Test-Path $full)) {
		Write-Error "Archivo no encontrado: $full"
		continue
	}

	Write-Host "Ejecutando $f en $Server.$Database"
	$cmd = "sqlcmd -S $Server -d $Database -E -i `"$full`""
	Write-Host $cmd
	$proc = Start-Process -FilePath sqlcmd -ArgumentList "-S", $Server, "-d", $Database, "-E", "-i", $full -NoNewWindow -Wait -PassThru
	if ($proc.ExitCode -ne 0) {
		Write-Error "sqlcmd retornó código $($proc.ExitCode) al ejecutar $f"
		break
	}
}

Write-Host "Despliegue finalizado." -ForegroundColor Green
