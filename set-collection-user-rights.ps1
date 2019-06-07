. $PSScriptRoot\settings.ps1


function Set-Rights {
#Set rights on the xDB connection database
    Write-Host "Setting Collection User rights" -ForegroundColor Green
    try
    {
        $sqlVariables = "DatabasePrefix = $SolutionPrefix", "UserName = $XConnectSqlCollectionUser", "Password = $XConnectSqlCollectionPassword"
        Invoke-Sqlcmd -ServerInstance $SqlServer `
                      -Username $SqlAdminUser `
                      -Password $SqlAdminPassword `
                      -InputFile "$PSScriptRoot\build\database\collectionusergrant.sql" `
                      -Variable $sqlVariables
    }
    catch
    {
        write-host "Set Collection User rights failed" -ForegroundColor Red
        throw
    }
}

Set-Rights