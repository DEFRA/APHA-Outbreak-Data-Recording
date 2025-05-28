using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.Word;
using UiPath.Word.Activities;
using UiPath.Word.Activities.API;
using UiPath.Word.Activities.API.Models;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace OutbreakDataRecording
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Word.Activities.API.IWordService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Mail.Activities.Api.IMailService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.Excel.Activities.API.IExcelService), typeof(UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.Excel.Activities.API.IExcelService excel { get => serviceContainer.Resolve<UiPath.Excel.Activities.API.IExcelService>(); }

        protected UiPath.Mail.Activities.Api.IMailService mail { get => serviceContainer.Resolve<UiPath.Mail.Activities.Api.IMailService>(); }

        protected UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService office365 { get => serviceContainer.Resolve<UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService>(); }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }

        protected UiPath.Word.Activities.API.IWordService word { get => serviceContainer.Resolve<UiPath.Word.Activities.API.IWordService>(); }
    }
}

namespace OutbreakDataRecording.ObjectRepository
{
    public static class Descriptors
    {
    }
}

namespace OutbreakDataRecording._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }
}