task :default => [:build, :unittests] do
end

task :build do
  msbuild = "C:/Windows/Microsoft.NET/Framework/v4.0.30319/msbuild.exe"
  sh "#{msbuild} SolYUtor.Extex.sln"
end

task :unittests do
  sh "Packages/NUnit.2.5.10.11092/tools/nunit-console.exe  Solyutor.Extex.Tests/bin/Debug/Solyutor.Extex.Tests.dll"
end