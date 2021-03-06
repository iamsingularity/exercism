﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

public class SublistTest
{
    [Test]
    public void Empty_equals_empty()
    {
        var list1 = new List<int>();
        var list2 = new List<int>();
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Equal));
    }

    [Test]
    public void Empty_is_a_sublist_of_anything()
    {
        var list1 = new List<int>();
        var list2 = new List<int> { 1, 2, 3, 4 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Sublist));
    }

    [Test]
    public void Anything_is_a_superlist_of_empty()
    {
        var list1 = new List<int> { 1, 2, 3, 4 };
        var list2 = new List<int>();
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Superlist));
    }

    [Test]
    public void One_is_not_two()
    {
        var list1 = new List<int> { 1 };
        var list2 = new List<int> { 2 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Unequal));
    }

    [Test]
    public void Compare_larger_equal_lists()
    {
        var list1 = new List<char>(Enumerable.Repeat('x', 1000));
        var list2 = new List<char>(Enumerable.Repeat('x', 1000));
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Equal));
    }

    [Test]
    public void Sublist_at_start()
    {
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = new List<int> { 1, 2, 3, 4, 5 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Sublist));
    }

    [Test]
    public void Sublist_in_middle()
    {
        var list1 = new List<int> { 4, 3, 2 };
        var list2 = new List<int> { 5, 4, 3, 2, 1 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Sublist));
    }

    [Test]
    public void Sublist_at_end()
    {
        var list1 = new List<int> { 3, 4, 5 };
        var list2 = new List<int> { 1, 2, 3, 4, 5 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Sublist));
    }

    [Test]
    public void Partially_matching_sublist_at_start()
    {
        var list1 = new List<int> { 1, 1, 2 };
        var list2 = new List<int> { 1, 1, 1, 2 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Sublist));
    }

    [Test]
    public void Sublist_early_in_huge_list()
    {
        var list1 = new List<int> { 3, 4, 5 };
        var list2 = new List<int>(Enumerable.Range(1, 1000000));
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Sublist));
    }

    [Test]
    public void Huge_sublist_not_in_huge_list()
    {
        var list1 = new List<int>(Enumerable.Range(10, 1000001));
        var list2 = new List<int>(Enumerable.Range(1, 1000000));
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Unequal));
    }

    [Test]
    public void Superlist_at_start()
    {
        var list1 = new List<int> { 1, 2, 3, 4, 5 };
        var list2 = new List<int> { 1, 2, 3 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Superlist));
    }

    [Test]
    public void Superlist_in_middle()
    {
        var list1 = new List<int> { 5, 4, 3, 2, 1 };
        var list2 = new List<int> { 4, 3, 2 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Superlist));
    }

    [Test]
    public void Superlist_at_end()
    {
        var list1 = new List<int> { 1, 2, 3, 4, 5 };
        var list2 = new List<int> { 3, 4, 5 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Superlist));
    }

    [Test]
    public void Partially_matching_superlist_at_start()
    {
        var list1 = new List<int> { 1, 1, 1, 2 };
        var list2 = new List<int> { 1, 1, 2 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Superlist));
    }

    [Test]
    public void Superlist_early_in_huge_list()
    {
        var list1 = new List<int>(Enumerable.Range(1, 1000000));
        var list2 = new List<int> { 3, 4, 5 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Superlist));
    }

    [Test]
    public void Recurring_values_sublist()
    {
        var list1 = new List<int> { 1, 2, 1, 2, 3 };
        var list2 = new List<int> { 1, 2, 3, 1, 2, 1, 2, 3, 2, 1 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Sublist));
    }

    [Test]
    public void Recurring_values_unequal()
    {
        var list1 = new List<int> { 1, 2, 1, 2, 3 };
        var list2 = new List<int> { 1, 2, 3, 1, 2, 3, 2, 3, 2, 1 };
        Assert.That(Sublist.Classify(list1, list2), Is.EqualTo(SublistType.Unequal));
    }
}