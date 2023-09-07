﻿using LLamaStack.Core.Common;
using LLamaStack.Core.Config;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LLamaStack.WebApi.Models
{
    public record CreateRequest : InferRequestBase, ISessionConfig
    {
        [Required]
        [DefaultValue("WizardLM-7B")]
        public string Model { get; set; }

        [Required]
        [DefaultValue(ExecutorType.Instruct)]
        public ExecutorType ExecutorType { get; set; }

        [DefaultValue("Below is an instruction that describes a task. Write a response that appropriately completes the request.")]
        public override string Prompt { get; set; }

        [DefaultValue("")]
        public string AntiPrompt { get; set; }

        [DefaultValue("")]
        public string OutputFilter { get; set; }

        [DefaultValue("")]
        public string InputSuffix { get; set; }

        [DefaultValue("")]
        public string InputPrefix { get; set; }
    }
}
