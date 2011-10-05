task :default do
  msbuild = "C:/Windows/Microsoft.NET/Framework/v4.0.30319/msbuild.exe"
  sh "#{msbuild} SolYUtor.Extex.sln"
end
