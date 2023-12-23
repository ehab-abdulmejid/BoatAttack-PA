using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using Unity.ProjectAuditor.Editor;
using Unity.ProjectAuditor.Editor.UI;
//using Unity.ProjectAuditor.Editor.UI.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
   // private ProjectAuditorWindow m_PaWindow => ProjectAuditorWindow.Instance;
    
    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator NewTestScriptSimplePasses()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<html><head><meta charset='utf-8'/>");
        sb.Append("<style>ul li{list-style:none;margin-top:3px;margin-bottom:3px;}");
        sb.Append("h1{font-size: 23px;margin-bottom: 0px;margin-top: 0px;");
        sb.Append("font-weight: normal;font-family: Arial;}");
        sb.Append("h2{margin: 3px;margin-left: 0px;font-size: 16px;}");
        sb.Append("h3{margin: 3px;font-size: 16px;}");
        sb.Append("h4{margin: 3px;margin-left: 0px;font-size: 13px;}");
        sb.Append("h5{margin: 3px;font-size: 11px;font-weight: normal;font-family: Arial;}");
        sb.Append("</style>");
        sb.Append("</head>");
        sb.Append("<body style='text-align: center;margin:auto;margin-top:0px;margin-bottom:5px;'>");
        sb.Append("Hello Ehab!!");
        sb.Append("</body>");
        sb.Append("</html>");
        
        StreamWriter sw1 = new StreamWriter(@"docs/index.html");
        
        sw1.Write(sb);
        sw1.Flush();
        sw1.Close();
        sw1.Dispose();
        /*ProjectAuditor aud = new ProjectAuditor();

        
        MethodInfo method = aud.GetType().GetMethod("AuditAsync",

            BindingFlags.NonPublic | BindingFlags.Instance);
        var report = method.Invoke(aud, new object[2] { null, null });
        
        Debug.Log(report.GetType());*/
        /*Assembly assembly = Assembly.LoadFrom("Packages/com.unity.project-auditor/Editor/UI/Unity.ProjectAuditor.Editor.UI.asmdef");
        object mc = assembly.CreateInstance("Unity.ProjectAuditor.Editor.UI.ProjectAuditorWindow");
        
        Type t = mc.GetType(); 
        BindingFlags bf = BindingFlags.Instance |  BindingFlags.NonPublic;
        MethodInfo mi = t.GetMethod("Show", bf); 
        mi.Invoke(mc, null);

        MethodInfo mii = t.GetMethod("Focus", bf); 
        mii.Invoke(mc, null);
        
        MethodInfo miii = t.GetMethod("Repaint", bf); 
        miii.Invoke(mc, null);*/

        yield return null;
        //ProjectAuditorWindow.Instance.Show();
        //ProjectAuditorWindow.Instance.Focus();
        //ProjectAuditorWindow.Instance.Repaint();

        /*var flagsValue = 1 << 0 | 1 << 1 | 1 << 2 | 1 << 3 | 1 << 4;
        m_PaWindow.GetType()
            .GetField("m_SelectedProjectAreas", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(m_PaWindow, flagsValue);

        MethodInfo method = ProjectAuditorWindow.Instance.GetType().GetMethod("Analyze",

            BindingFlags.NonPublic | BindingFlags.Instance);
        method.Invoke(ProjectAuditorWindow.Instance, null);

        EditorUtility.RequestScriptReload();
        yield return new WaitForDomainReload();
        
        var projectReport = (ProjectReport)m_PaWindow.GetType().
            GetField("m_ProjectReport", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(m_PaWindow);

        projectReport.Save("project-auditor-report.json");*/
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
