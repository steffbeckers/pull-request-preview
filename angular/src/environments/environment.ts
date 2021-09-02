import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'PullRequestPreview',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44358',
    redirectUri: baseUrl,
    clientId: 'PullRequestPreview_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone PullRequestPreview',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44358',
      rootNamespace: 'PullRequestPreview',
    },
  },
} as Environment;
