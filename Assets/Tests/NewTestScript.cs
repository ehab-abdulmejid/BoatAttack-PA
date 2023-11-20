using System.Collections;
using System.Reflection;
using NUnit.Framework;
using Unity.ProjectAuditor.Editor;
using Unity.ProjectAuditor.Editor.UI;
//using Unity.ProjectAuditor.Editor.UI.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    private ProjectAuditorWindow m_PaWindow => ProjectAuditorWindow.Instance;
    
    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator NewTestScriptSimplePasses()
    {
        ProjectAuditorWindow.Instance.Show();
        ProjectAuditorWindow.Instance.Focus();
        ProjectAuditorWindow.Instance.Repaint();

        var flagsValue = 1 << 0 | 1 << 1 | 1 << 2 | 1 << 3 | 1 << 4;
        m_PaWindow.GetType()
            .GetField("m_SelectedProjectAreas", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(m_PaWindow, flagsValue);

        MethodInfo method = ProjectAuditorWindow.Instance.GetType().GetMethod("Analyze",

            BindingFlags.NonPublic | BindingFlags.Instance);
        method.Invoke(ProjectAuditorWindow.Instance, null);

        EditorUtility.RequestScriptReload();
        yield return new WaitForDomainReload();
        
        var projectReport = (ProjectReport)m_PaWindow.GetType().
            GetField("m_ProjectReport", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(m_PaWindow);

        projectReport.Save("project-auditor-report.json");
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
