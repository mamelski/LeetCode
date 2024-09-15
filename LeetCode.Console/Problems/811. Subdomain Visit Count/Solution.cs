namespace LeetCode.Console.Problems._811._Subdomain_Visit_Count;

public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {

        var domCount = new Dictionary<string, int>();
        foreach (var cpDomain in cpdomains)
        {
            var split = cpDomain.Split(' ');
            var count = int.Parse(split[0]);
            var domain = split[1];

            if (!domCount.TryAdd(domain, count))
            {
                domCount[domain] += count;
            }

            var domainSplitted = domain.Split('.');
            if (domainSplitted.Length == 3)
            {
                var subDomain = domainSplitted[1] + '.' + domainSplitted[2];
                if (!domCount.TryAdd(subDomain, count))
                {
                    domCount[subDomain] += count;
                }
            }
            
            if (domainSplitted.Length == 2 || domainSplitted.Length == 3)
            {
                var subDomain = domainSplitted[^1];
                if (!domCount.TryAdd(subDomain, count))
                {
                    domCount[subDomain] += count;
                }
            }
        }
        
        var res = new List<string>();
        foreach (var domain in domCount.Keys)
        {
            res.Add($"{domCount[domain]} {domain}");
        }
        return res;
    }
}