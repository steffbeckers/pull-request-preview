# PR Preview

Testing automated Azure DevOps PR preview deployments with K8s.

## Azure DevOps project

[https://dev.azure.com/steffbeckers/pull-request-preview](https://dev.azure.com/steffbeckers/pull-request-preview)

## Commands

```powershell
helm upgrade pr-2 back-end `
--install `
--namespace pull-request-preview-pr-2 `
--create-namespace `
--set image.tag=pr-2 `
--set image.pullPolicy=Always `
--set app.domain=2.pr.pull-request-preview.steffbeckers.eu `
--set app.connectionString="Server=mssql-mssql-linux.mssql.svc.cluster.local;Database=PullRequestPreview-PR-2;User ID=app;Password=*=ac5bLtp?Dd9TnUkEJD"
```

```
helm delete pr-2 -n pull-request-preview-pr-2
```
