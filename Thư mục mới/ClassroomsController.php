<?php

namespace App\Http\Controllers;

use App\Models\Classrooms;
use App\Http\Requests\StoreClassroomsRequest;
use App\Http\Requests\UpdateClassroomsRequest;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Redirect;

class ClassroomsController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $obj = new Classrooms();
        $classrooms = $obj->index();
        return view('classrooms.index', [
            'classrooms' => $classrooms
        ]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('classrooms.create');
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \App\Http\Requests\StoreClassroomsRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StoreClassroomsRequest $request)
    {
        $obj = new Classrooms();
        $obj->name = $request->name;
        $obj->count_student = $request->count_student;
        $obj->store();
        return Redirect::route('classroom.index');
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\Classrooms  $classrooms
     * @return \Illuminate\Http\Response
     */
    public function show(Classrooms $classrooms)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  \App\Models\Classrooms  $classrooms
     * @return \Illuminate\Http\Response
     */
    public function edit(Classrooms $classrooms, Request $request)
    {
        $obj = new Classrooms();
        $obj->id  = $request->id;
        $classrooms = $obj->edit();
        return view('classrooms.edit', [
            'classrooms' => $classrooms
        ]);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \App\Http\Requests\UpdateClassroomsRequest  $request
     * @param  \App\Models\Classrooms  $classrooms
     * @return \Illuminate\Http\Response
     */
    public function update(UpdateClassroomsRequest $request, Classrooms $classrooms)
    {
        $obj = new Classrooms();
        $obj->id = $request->id;
        $obj->name = $request->name;
        $obj->count_student = $request->count_student;
        $obj->updateClassrooms();
        return Redirect::route('classroom.index');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  \App\Models\Classrooms  $classrooms
     * @return \Illuminate\Http\Response
     */
    public function destroy(Classrooms $classrooms, Request $request)
    {
        $obj = new Classrooms();
        $obj->id = $request->id;
        $obj->destroyClassrooms();
        return Redirect::route('classroom.index');
    }
}
