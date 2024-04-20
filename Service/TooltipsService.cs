

public class TooltipsService : ITooltipsService
{
    private readonly ITooltipsRepository _tooltipsRepository;

    public TooltipsService(ITooltipsRepository tooltipsRepository)
    {
        _tooltipsRepository = tooltipsRepository;
    }

    async Task<IList<Tooltips>> ITooltipsService.ListAll()
    {
        var Tooltips = await _tooltipsRepository.ListAll();

        return (List<Tooltips>)Tooltips;
    }
}