---
external help file: Az.Databricks-help.xml
Module Name: Az.Databricks
online version: https://learn.microsoft.com/powershell/module/az.databricks/get-azdatabricksoutboundnetworkdependenciesendpoint
schema: 2.0.0
---

# Get-AzDatabricksOutboundNetworkDependenciesEndpoint

## SYNOPSIS
Gets the list of endpoints that VNET Injected Workspace calls Azure Databricks Control Plane.
You must configure outbound access with these endpoints.
For more information, see https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/udr

## SYNTAX

```
Get-AzDatabricksOutboundNetworkDependenciesEndpoint -ResourceGroupName <String> -WorkspaceName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets the list of endpoints that VNET Injected Workspace calls Azure Databricks Control Plane.
You must configure outbound access with these endpoints.
For more information, see https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/udr

## EXAMPLES

### Example 1: Gets the list of endpoints that VNET Injected Workspace calls Azure Databricks Control Plane.
```powershell
Get-AzDatabricksOutboundNetworkDependenciesEndpoint -ResourceGroupName azps_test_gp_db -WorkspaceName azps-databricks-workspace-t2
```

```output
Category
--------
Webapp
Control Plane NAT
Extended infrastructure
Azure Storage
Azure My SQL
Azure Servicebus
```

This command gets the list of endpoints that VNET Injected Workspace calls Azure Databricks Control Plane.
You must configure outbound access with these endpoints.
For more information, see https://learn.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/udr

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceName
The name of the workspace.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20240501.IOutboundEnvironmentEndpoint

## NOTES

## RELATED LINKS
