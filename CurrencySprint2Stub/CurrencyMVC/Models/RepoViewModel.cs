using System;
using Currency;
using System.Collections.Generic;

public class RepoViewModel
{
    ICurrencyRepo repo;

    public RepoViewModel(ICurrencyRepo repo)
    {
        this.repo = repo;
    }

    public decimal TotalValue
    {
        get { return repo.TotalValue(); }
    }

    public void MakeChange(decimal Amount)
    {
        repo = repo.MakeChange(Amount);
    }

    public List<ICoin> Coins
    {
        get { return repo.Coins; }
    }

}