// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from 'src\OpenTelemetry.SemanticConventions\scripts\templates\registry\SemanticConventionsAttributes.cs.j2' </auto-generated>

#nullable enable

#pragma warning disable CS1570 // XML comment has badly formed XML

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class TelemetryAttributes
{
    /// <summary>
    /// The name of the auto instrumentation agent or distribution, if used.
    /// </summary>
    /// <remarks>
    /// Official auto instrumentation agents and distributions SHOULD set the <c>telemetry.distro.name</c> attribute to
    /// a string starting with <c>opentelemetry-</c>, e.g. <c>opentelemetry-java-instrumentation</c>.
    /// </remarks>
    public const string AttributeTelemetryDistroName = "telemetry.distro.name";

    /// <summary>
    /// The version string of the auto instrumentation agent or distribution, if used.
    /// </summary>
    public const string AttributeTelemetryDistroVersion = "telemetry.distro.version";

    /// <summary>
    /// The language of the telemetry SDK.
    /// </summary>
    public const string AttributeTelemetrySdkLanguage = "telemetry.sdk.language";

    /// <summary>
    /// The name of the telemetry SDK as defined above.
    /// </summary>
    /// <remarks>
    /// The OpenTelemetry SDK MUST set the <c>telemetry.sdk.name</c> attribute to <c>opentelemetry</c>.
    /// If another SDK, like a fork or a vendor-provided implementation, is used, this SDK MUST set the
    /// <c>telemetry.sdk.name</c> attribute to the fully-qualified class or module name of this SDK's main entry point
    /// or another suitable identifier depending on the language.
    /// The identifier <c>opentelemetry</c> is reserved and MUST NOT be used in this case.
    /// All custom identifiers SHOULD be stable across different versions of an implementation.
    /// </remarks>
    public const string AttributeTelemetrySdkName = "telemetry.sdk.name";

    /// <summary>
    /// The version string of the telemetry SDK.
    /// </summary>
    public const string AttributeTelemetrySdkVersion = "telemetry.sdk.version";

    /// <summary>
    /// The language of the telemetry SDK.
    /// </summary>
    public static class TelemetrySdkLanguageValues
    {
        /// <summary>
        /// cpp.
        /// </summary>
        public const string Cpp = "cpp";

        /// <summary>
        /// dotnet.
        /// </summary>
        public const string Dotnet = "dotnet";

        /// <summary>
        /// erlang.
        /// </summary>
        public const string Erlang = "erlang";

        /// <summary>
        /// go.
        /// </summary>
        public const string Go = "go";

        /// <summary>
        /// java.
        /// </summary>
        public const string Java = "java";

        /// <summary>
        /// nodejs.
        /// </summary>
        public const string Nodejs = "nodejs";

        /// <summary>
        /// php.
        /// </summary>
        public const string Php = "php";

        /// <summary>
        /// python.
        /// </summary>
        public const string Python = "python";

        /// <summary>
        /// ruby.
        /// </summary>
        public const string Ruby = "ruby";

        /// <summary>
        /// rust.
        /// </summary>
        public const string Rust = "rust";

        /// <summary>
        /// swift.
        /// </summary>
        public const string Swift = "swift";

        /// <summary>
        /// webjs.
        /// </summary>
        public const string Webjs = "webjs";
    }
}
