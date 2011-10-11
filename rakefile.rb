require 'albacore'

task :default => [:build, :unittests] do
end

msbuild :build do |msb|
  msb.solution = "Solyutor.Extex.sln"
  msb.targets :clean, :build
  msb.properties :configuration => :release
end

nunit :unittests do |nunit|
  nunit.command = "Packages/NUnit.2.5.10.11092/tools/nunit-console.exe"
  nunit.assemblies "Solyutor.Extex.Tests/bin/Debug/Solyutor.Extex.Tests.dll"
end