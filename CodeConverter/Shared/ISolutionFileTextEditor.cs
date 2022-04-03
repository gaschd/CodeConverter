﻿namespace ICSharpCode.CodeConverter.Shared;

public interface ISolutionFileTextEditor
{
    List<(string Find, string Replace, bool FirstOnly)> GetProjectFileProjectReferenceReplacements(
        IEnumerable<(string Name, string RelativeProjPath, string ProjContents)> projTuples, string sourceSolutionContents);
}