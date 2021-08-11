// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Policy Root.
    /// </summary>
    public partial class PolicyRoot : Entity
    {
    
        /// <summary>
        /// Gets or sets authentication methods policy.
        /// The authentication methods and the users that are allowed to use them to sign in and perform multi-factor authentication (MFA) in Azure Active Directory (Azure AD).
        /// </summary>
        [JsonPropertyName("authenticationMethodsPolicy")]
        public AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets authentication flows policy.
        /// The policy configuration of the self-service sign-up experience of external users.
        /// </summary>
        [JsonPropertyName("authenticationFlowsPolicy")]
        public AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets activity based timeout policies.
        /// The policy that controls the idle time out for web sessions for applications.
        /// </summary>
        [JsonPropertyName("activityBasedTimeoutPolicies")]
        public IPolicyRootActivityBasedTimeoutPoliciesCollectionPage ActivityBasedTimeoutPolicies { get; set; }

        /// <summary>
        /// Gets or sets activityBasedTimeoutPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("activityBasedTimeoutPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ActivityBasedTimeoutPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets authorization policy.
        /// The policy that controls Azure AD authorization settings.
        /// </summary>
        [JsonPropertyName("authorizationPolicy")]
        public AuthorizationPolicy AuthorizationPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets claims mapping policies.
        /// The claim-mapping policies for WS-Fed, SAML, OAuth 2.0, and OpenID Connect protocols, for tokens issued to a specific application.
        /// </summary>
        [JsonPropertyName("claimsMappingPolicies")]
        public IPolicyRootClaimsMappingPoliciesCollectionPage ClaimsMappingPolicies { get; set; }

        /// <summary>
        /// Gets or sets claimsMappingPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("claimsMappingPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ClaimsMappingPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets home realm discovery policies.
        /// The policy to control Azure AD authentication behavior for federated users.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies")]
        public IPolicyRootHomeRealmDiscoveryPoliciesCollectionPage HomeRealmDiscoveryPolicies { get; set; }

        /// <summary>
        /// Gets or sets homeRealmDiscoveryPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string HomeRealmDiscoveryPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets permission grant policies.
        /// The policy that specifies the conditions under which consent can be granted.
        /// </summary>
        [JsonPropertyName("permissionGrantPolicies")]
        public IPolicyRootPermissionGrantPoliciesCollectionPage PermissionGrantPolicies { get; set; }

        /// <summary>
        /// Gets or sets permissionGrantPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("permissionGrantPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PermissionGrantPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token issuance policies.
        /// The policy that specifies the characteristics of SAML tokens issued by Azure AD.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies")]
        public IPolicyRootTokenIssuancePoliciesCollectionPage TokenIssuancePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenIssuancePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TokenIssuancePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token lifetime policies.
        /// The policy that controls the lifetime of a JWT access token, an ID token, or a SAML 1.1/2.0 token issued by Azure AD.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies")]
        public IPolicyRootTokenLifetimePoliciesCollectionPage TokenLifetimePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenLifetimePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TokenLifetimePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets feature rollout policies.
        /// The feature rollout policy associated with a directory object.
        /// </summary>
        [JsonPropertyName("featureRolloutPolicies")]
        public IPolicyRootFeatureRolloutPoliciesCollectionPage FeatureRolloutPolicies { get; set; }

        /// <summary>
        /// Gets or sets featureRolloutPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("featureRolloutPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string FeatureRolloutPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets admin consent request policy.
        /// The policy by which consent requests are created and managed for the entire tenant.
        /// </summary>
        [JsonPropertyName("adminConsentRequestPolicy")]
        public AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access policies.
        /// The custom rules that define an access scenario.
        /// </summary>
        [JsonPropertyName("conditionalAccessPolicies")]
        public IPolicyRootConditionalAccessPoliciesCollectionPage ConditionalAccessPolicies { get; set; }

        /// <summary>
        /// Gets or sets conditionalAccessPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("conditionalAccessPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ConditionalAccessPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets identity security defaults enforcement policy.
        /// The policy that represents the security defaults that protect against common attacks.
        /// </summary>
        [JsonPropertyName("identitySecurityDefaultsEnforcementPolicy")]
        public IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
    
    }
}

