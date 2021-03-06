﻿using System;
using System.IO;
using Klarna.Rest.Core.Model;
using Klarna.Rest.Core.Model.Enum;
using Klarna.Rest.Core.Model.HostedPaymentPage;
using Klarna.Rest.Core.Model.MerchantCardService;
using Newtonsoft.Json;
using Xunit;

namespace Klarna.Rest.Core.Tests.Models
{
    public class CustomerTokenReadCustomerTokenDetailsTest
    {
        [Fact]
        public void CanReadResponseJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "CustomerTokenReadCustomerTokenResponse.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeResponse()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "CustomerTokenReadCustomerTokenResponse.json"));
            var response = JsonConvert.DeserializeObject<CustomerTokenDetails>(json);
        }
    }

    public class CustomerTokenCreateOrderTest
    {
        [Fact]
        public void CanReadRequestJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "CustomerTokenCreateNewOrderRequest.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanReadResponseJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "CustomerTokenCreateNewOrderResponse.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeRequest()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "CustomerTokenCreateNewOrderRequest.json"));
            var request = JsonConvert.DeserializeObject<CustomerTokenOrder>(json);
        }

        [Fact]
        public void CanDeserializeResponse()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "CustomerTokenCreateNewOrderResponse.json"));
            var response = JsonConvert.DeserializeObject<CustomerTokenCreateOrderResponse>(json);
        }
    }

    public class HostedPaymentPageCreateSessionTest
    {
        [Fact]
        public void CanReadRequestJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageCreateSessionRequest.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanReadResponseJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageCreateSessionResponse.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeRequest()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageCreateSessionRequest.json"));
            var request = JsonConvert.DeserializeObject<Model.HostedPaymentPage.SessionCreationRequestV1>(json);
        }

        [Fact]
        public void CanDeserializeResponse()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageCreateSessionResponse.json"));
            var response = JsonConvert.DeserializeObject<Model.HostedPaymentPage.SessionCreationResponseV1>(json);
        }
        
        [Fact]
        public void TestClient()
        {
            SessionResponseV1 responseObject = new SessionResponseV1();
            responseObject.Status = HostedPaymentPageStatus.COMPLETED;
            responseObject.AuthorizationToken = "b4bd3423-24e3";
            responseObject.UpdatedAt = "2038-01-19T03:14:07.000Z";
            responseObject.SessionId = "1234";
            Model.HostedPaymentPage.SessionResponseV1 casted = responseObject;
            Assert.True(casted.AuthorizationToken.Equals("b4bd3423-24e3"));
        }
    }

    public class HostedPaymentPageDistributeLinkTest
    {
        [Fact]
        public void CanReadRequestJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageDistributeLinkToSessionRequest.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeRequest()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageDistributeLinkToSessionRequest.json"));
            var request = JsonConvert.DeserializeObject<HostedPaymentPageDistributeLink>(json);
        }
    }

    public class HostedPaymentPageGetSessionStatusTest
    {
        [Fact]
        public void CanReadResponseJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageGetSessionStatusResponse.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeResponse()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "HostedPaymentPageGetSessionStatusResponse.json"));
            var response = JsonConvert.DeserializeObject<HostedPaymentPageSessionStatus>(json);
        }
    }

    public class VirtualCardServiceCreateSettlementTest
    {
        [Fact]
        public void CanReadRequestJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceCreateSettlementRequest.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanReadResponseJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceCreateSettlementResponse.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeRequest()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceCreateSettlementRequest.json"));
            var request = JsonConvert.DeserializeObject<VirtualCardCreateSettlementRequest>(json);
        }

        [Fact]
        public void CanDeserializeResponse()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceCreateSettlementResponse.json"));
            var response = JsonConvert.DeserializeObject<VirtualCardSettlement>(json);
        }
    }

    public class VirtualCardServiceRetrieveSettlementTest
    {
        [Fact]
        public void CanReadResponseJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceGetExistingSettlementResponse.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeResponse()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceGetExistingSettlementResponse.json"));
            var response = JsonConvert.DeserializeObject<VirtualCardSettlement>(json);
        }
    }

    public class VirtualCardServiceRetrieveSettledOrdersSettlementTest
    {
        [Fact]
        public void CanReadResponseJson()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceGetSettledOrdersSettlementResponse.json"));
            Assert.True(!string.IsNullOrEmpty(json));
        }

        [Fact]
        public void CanDeserializeResponse()
        {
            var json = File.ReadAllText(Path.Combine(System.Environment.CurrentDirectory, "Data", "VirtualCardServiceGetSettledOrdersSettlementResponse.json"));
            var response = JsonConvert.DeserializeObject<VirtualCardSettlement>(json);
        }
        
        [Fact]
        public void TestClient()
        {
            SettlementResponse newResponse = new SettlementResponse();
            newResponse.SettlementId = "ABCD1234";
            newResponse.OrderId = "DEFG5678";
            newResponse.CreatedAt = "2038-01-19T03:14:07.000Z";
            newResponse.ExpiresAt = "2038-01-27T03:14:07.000Z";
            VirtualCardSettlement casted = newResponse;
            Assert.True(casted.SettlementId.Equals("ABCD1234"));
            Assert.True(casted.OrderId.Equals("DEFG5678"));
            Assert.True(casted.CreatedAt.Equals("2038-01-19T03:14:07.000Z"));
            Assert.True(casted.ExpiresAt.Equals("2038-01-27T03:14:07.000Z"));
        }
    }

}