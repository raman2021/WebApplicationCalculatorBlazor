using WebApplicationCalculatorAPI;

app.UseEndpoints(endpoints =>
{
    endpoints.MapPowerToolsEFCore<ThingContext>();
    endpoints.MapRazorPages();
});


