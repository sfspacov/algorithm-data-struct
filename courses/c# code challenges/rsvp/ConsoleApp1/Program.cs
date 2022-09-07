InviteDetails();


static void InviteDetails()
{
    var family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
    var friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
    var rsvp = new List<string>() { "Kelly", "Harrison" };

    //var invitedes = new HashSet<string>(family.Concat(friends));
    var inviteds = new HashSet<string>(family);
    inviteds.UnionWith(friends);

    //var duplicates = new HashSet<string>(
    //    family
    //    .Concat(friends)
    //    .GroupBy(x => x)
    //    .Where(x => x.Count() > 1)
    //    .Select(x => x.Key));
    var duplicates = new HashSet<string>(family);
    duplicates.IntersectWith(friends);

    //var missing = new HashSet<string>(invitedes.Except(rsvp));
    var missing = new HashSet<string>(rsvp);
    missing.SymmetricExceptWith(inviteds);
}