# VS 2015 Parallel Unit Tests
This is a demo project to show off how to use parallel unit tests in Visual Studio 2015. This code is a companion to the blog post located here: https://johnkoerner.com/vs2015/parallel-test-execution-in-visual-studio-2015-update-1-might-not-be-what-you-expect/

A great way to test this is to build the code and run the unit tests without selecting a test settings file. You will see each test take 5 seconds and they will be run serially.
Next, select the `runsettings` file and re-run the tests. You will see that the tests will run in parallel across projects.